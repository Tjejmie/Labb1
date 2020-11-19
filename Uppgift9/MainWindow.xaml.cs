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

namespace Uppgift9
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

        private void btnKontrollera_Click(object sender, RoutedEventArgs e)
        {
            string namn = txtNamn.Text;
            int ålder = int.Parse(txtAge.Text);
            bool medVuxen = rbtnMedVuxen.IsChecked.Value;
            bool utanVuxen = rbtnUtanVuxen.IsChecked.Value;

            if (ålder >= 15)
            {
                if (rbtnMedVuxen.IsChecked == true)
                {
                    lblResultat.Content = ($"Hej {namn}! Du är {ålder} år gammal och får se alla filmer med eller utan vuxen.");
                }
                if (rbtnUtanVuxen.IsChecked == true)
                {
                    lblResultat.Content = ($"Hej {namn}. Du är {ålder} år gammal och får se alla filmer utan vuxen.");
                }
                
            }

            else if (ålder >= 11)
            {
                if (rbtnMedVuxen.IsChecked == true)
                {
                    lblResultat.Content = ($"Hej {namn}! Du är {ålder} år gammal och får se filmer med 11-årsgräns med eller utan vuxen. ");
                }
                else if (rbtnUtanVuxen.IsChecked == true)
                {
                    lblResultat.Content = ($"Hej {namn}! Du är {ålder} år gammal och får se filmer med 11-årsgräns utan vuxen.");
                }
                
            }

            else if (ålder >= 7)
            {
                if (rbtnMedVuxen.IsChecked == true)
                {
                    lblResultat.Content = ($"Hej {namn}! Du är {ålder} år gammal och får se filmer med 11-årsgräns eftersom du går med en vuxen");
                }
                else if (rbtnUtanVuxen.IsChecked == true)
                {
                    lblResultat.Content = ($"Hej {namn}! Du är {ålder} år gammal och få se filmer med 7-årsgräns.");
                }       
            
            }

            else
            {
                if (rbtnMedVuxen.IsChecked == true)
                {
                    lblResultat.Content = ($"Hej {namn}! Du är {ålder} år gammal och får se alla barntillåtna filmer, med eller utan vuxen.");
                }

                else if (rbtnUtanVuxen.IsChecked== true)
                {
                    lblResultat.Content = ($"Hej {namn}! Du är {ålder} år gammal och får se alla barnfilmer utan en vuxen närvarande.");
                }
                
            }

        }

  
    }
}
