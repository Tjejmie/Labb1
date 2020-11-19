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

namespace Uppgift15
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
        int countVowels = 0;

        private void btnKnapp_Click(object sender, RoutedEventArgs e)
        {
            string charInput = txtBoxRotvälska.Text;
            int allThemVowels = NumberOfVowels(charInput);
            lblVokaler.Content = countVowels.ToString();
            txtBlockResultat.Text = Jibberish(txtBoxRotvälska.Text);
            lblVokaler.Content = ($"Antal vokaler: {countVowels}");
        }

        public string Jibberish (string charInput)
        {
            string textTranslated = "";
            foreach (char c in charInput)
            {
                bool lookatSmall = SmallVowel(c);
                bool lookatBig = BigVowel(c);

                if (lookatSmall == true)
                {
                    textTranslated += "ö";
                }

                else if (lookatBig == true)
                {
                    textTranslated += "Ö";
                }
                else
                {
                    textTranslated += c.ToString();
                }
            } return textTranslated;
        }

        public int NumberOfVowels (string charInput)
            {
                foreach (char letter in charInput)
                {
                    bool vowelIs = IsVowel(letter);
                    if (vowelIs == true)
                    {
                    countVowels++;
                    }
                } return countVowels;
            }

        public bool SmallVowel (char character)
        {
            string smallVowels = "aouiyeåäö";
            bool maybeVowelSmall = false;
            foreach (char vow in smallVowels)
            {
                if (vow == character)
                {
                    maybeVowelSmall = true;
                    break;
                }
            } return maybeVowelSmall;
        }

        public bool BigVowel (char character)
        {
            string bigVowels = "AOUIYEÅÄÖ";
            bool maybeVowelBig = false;
            foreach (char vow in bigVowels)
            {
                if (vow == character)
                {
                    maybeVowelBig = true;
                    break;
                }
            } return maybeVowelBig;
        }

        private bool IsVowel (char character)
        {
            string allVowels = "aouiyeåäöAOUIYEÅÄÖ";
            bool theVowel = false;

            foreach (char vow in allVowels)
            {
                if (vow == character)
                {
                    theVowel = true;
                    break;
                }
            } return theVowel;
        }

        
        
        
    }
}
