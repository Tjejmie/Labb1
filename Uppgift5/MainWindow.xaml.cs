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

namespace Uppgift5
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {

            int tal1 = 0;
            int tal2 = 0;
            tal1 = int.Parse(txtBox1.Text);
            tal2 = int.Parse(txtBox2.Text);
            int totalsum = tal1 + tal2;
            txtBox3.Text = Convert.ToString(totalsum);



            

            





            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            txtBox3.Clear();
            
        }
    }
}
