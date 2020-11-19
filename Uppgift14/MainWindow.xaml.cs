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

namespace Uppgift14
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
        public bool CheckForLetters (string textInput)
        {
            foreach (char c in textInput)
            {
                if (char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
        
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            string text = txtBirthYear.Text;

            if (CheckForLetters(text) == false)
            {
                MessageBox.Show("Du får bara mata in siffror.");
            }
            else 
            {
                int födelseår = int.Parse(txtBirthYear.Text);
                int år = DateTime.Now.Year;
                int resultat = år - födelseår;
                MessageBox.Show($"Du är {resultat} år gammal");
            }
        }
    }
}
