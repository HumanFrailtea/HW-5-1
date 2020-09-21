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

namespace HW_5_1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n1, amount, n2, n3, n4, n5;
 
            String money = one.Text;
            n1 = Int32.Parse(money);
            amount = 100 - n1;
            n2 = amount / 25;
            amount = amount % 25;
            n3 = amount / 10;
            amount = amount % 10;
            n4 = amount / 5;
            amount = amount % 5;
            n5 = amount;
        
            MessageBox.Show("Your interest is : " + n2 + "quarters " + n3 + "dimes" + n4 + "nickels" + n5 + "pennies");
        }
    }
}
