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

namespace Uppgift6s
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

        private void btnRensa_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            txtBoxResultat.Clear();

            lblResultat.Content = "Summa";
            lblResultat.Content = "Resultat";

            lblResultat.Content = "Differens";
            lblResultat.Content = "Resultat";

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {




            double tal1 = 0;
            double tal2 = 0;

            tal1 = int.Parse(txtBox1.Text);
            tal2 = int.Parse(txtBox2.Text);

            double totalsum = tal1 + tal2;
            txtBoxResultat.Text = Convert.ToString(totalsum);

            lblResultat.Content = "Resultat";
            lblResultat.Content = "Differens";



            lblResultat.Content = "Resultat";
            lblResultat.Content = "Summa";


        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = 0;
            double tal2 = 0;

            tal1 = int.Parse(txtBox1.Text);
            tal2 = int.Parse(txtBox2.Text);

            double totalsum = tal1 - tal2;
            txtBoxResultat.Text = Convert.ToString(totalsum);

            lblResultat.Content = "Resultat";
            lblResultat.Content = "Differens";
        }

        private void btnGånger_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = 0;
            double tal2 = 0;

            tal1 = int.Parse(txtBox1.Text);
            tal2 = int.Parse(txtBox2.Text);

            double totalsum = tal1 * tal2;
            txtBoxResultat.Text = Convert.ToString(totalsum);

            lblResultat.Content = "Resultat";
            lblResultat.Content = "Produkt";

        }

        private void btnDelad_Click(object sender, RoutedEventArgs e)
        {
            double tal1 = 0;
            double tal2 = 0;

            tal1 = double.Parse(txtBox1.Text);
            tal2 = double.Parse(txtBox2.Text);

            double totalsum = tal1 / tal2;
            txtBoxResultat.Text = Convert.ToString(totalsum);

            lblResultat.Content = "Resultat";
            lblResultat.Content = "Produkt";
        }
    }
}
