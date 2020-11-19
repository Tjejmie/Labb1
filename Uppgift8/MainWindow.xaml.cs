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

namespace Uppgift8
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

        private void btnKonvertera_Click(object sender, RoutedEventArgs e)
        {
            double galleoner = double.Parse(txtGalleoner.Text);
            double siklar = double.Parse(txtSiklar.Text);
            double knutingar = double.Parse(txtKnutingar.Text);
            double resultat = (galleoner + (siklar / 17) + (knutingar / 493)) * 62.02;
            lblResultat.Content = Math.Round(resultat).ToString() + "SEK";



        }

     
    }
}
