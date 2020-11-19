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

namespace Uppgift13
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
        
        int counter = 0;

        private void btnRäkna_Click(object sender, RoutedEventArgs e)
        {
            string text = txtBoxText.Text.ToLower();
            string letter = txtBoxSearch.Text.ToLower();

            foreach (char a in text)
            {
                if (a == letter[0])
                {
                    counter++;
                }
            }

            txtBlockResultat.Text = ($"Hittade bokstaven {letter} {counter} gånger");

            
        }
    }
}
