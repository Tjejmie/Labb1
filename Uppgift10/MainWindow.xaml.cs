using System;
using System.Diagnostics;
using System.Windows;

namespace Uppgift10
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly 
        Random coincidence = new Random();
        int slumptal = coincidence.Next(0,1000);
        private int numberOfGuesses = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSlumpa_Click(object sender, RoutedEventArgs e)
        {
            Random coincidence = new Random();
            slumptal = coincidence.Next(0, 1000);
            IsEnabled = btnGissa.IsEnabled = true;
            
            
        }

        private void btnGissa_Click(object sender, RoutedEventArgs e)
        {
            

            int siffra = 0;
            siffra = int.Parse(txtBoxTal.Text);

            if (siffra == slumptal)
            {
                numberOfGuesses++;
                lblSvar.Content = ($"Grattis, du gissade rätt på {numberOfGuesses} försök!");
            }

            else if (siffra > slumptal + 100)
            {
                numberOfGuesses++;
                lblSvar.Content = ($"Oh, du är inte ens nära. Du gissade alldeles för högt");
            }

            else if (siffra > slumptal)
            {
                numberOfGuesses++;
                lblSvar.Content = ($"Oh, du är ganska nära. Du gissade lite för högt.");
            }

            else if (siffra < slumptal - 100)
            {
                numberOfGuesses++;
                lblSvar.Content = ($"Oh, du är inte ens nära. Du gissade alldeles för lågt.");
            }

            else if (siffra < slumptal)
            {
                numberOfGuesses++;
                lblSvar.Content = ($"Oh, du är ganska nära. Du gissade lite för lågt.");
            }
        }
    }
}
