using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uppgift12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()

        {
            InitializeComponent();
        }

        double[] Nummer = new double[5];
        int counter = 0;

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            double value = double.Parse(txtNumbers.Text);
            
            if (counter <= 5)
            {
                Nummer[counter] = value;
                counter++;
            }

            lstNumbers.ItemsSource = null;
            lstNumbers.ItemsSource = Nummer;
            
            if (counter == 5)
            {
                double resultat;
                resultat = (Nummer[0] + Nummer[1] + Nummer[2] + Nummer[3] + Nummer[4]) / counter;
                txtMedelvärde.Text = resultat.ToString();

                btnOk.IsEnabled = false;
            }  
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            counter = 0;
            txtMedelvärde.Clear();
            txtNumbers.Clear();
            lstNumbers.ItemsSource = null;
            Array.Clear(Nummer, 0, Nummer.Length);

            btnOk.IsEnabled = true;

            txtNumbers.Focus();
        }
    }
}
