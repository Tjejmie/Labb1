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

namespace Uppgift11
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
        
        Random r = new Random();

        private void btnMindreOtur_Click(object sender, RoutedEventArgs e)
        {
            prgBar.Value -= 5;
        }

        private void btnMerOtur_Click(object sender, RoutedEventArgs e)
        {
            prgBar.Value += 5;
        }

        private void btnStarta_Click(object sender, RoutedEventArgs e)
        {
            int tries = int.Parse(txtBoxFörsök.Text);
            int rättHåll = 0;
            int felHåll = 0;

            for (int i = 0; i < tries; i++)
            {
                int antal = r.Next(1, 100);
                if (prgBar.Value < antal)
                {
                    rättHåll++;
                }
                else if (prgBar.Value > antal)
                {
                    felHåll++;
                }
                lblRätt.Content = ($"Smörgåsar åt rätt håll: {rättHåll}");
                lblFel.Content = ($"Smårgåsar åt fel håll: {felHåll}");

            }
        }
    }
}
