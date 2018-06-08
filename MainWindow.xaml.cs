/* Ethan Shipston
 * U5AddCoins
 * 6/7/2018
 * A program that counts your change
 */
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

namespace U5AddCoins
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int toonies;
        int loonies;
        int quarters;
        int dimes;
        int nickels;
        double total;
        public MainWindow()
        {
            InitializeComponent();
        }

        public void getDollarAmount(int t, int l, double q, double d, double n)
        {
            t = t * 2;
            q = q * 0.25;
            d = d * 0.10;
            n = n * 0.05;
            total = t + l + q + d + n;
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txtToonies.Text, out toonies);
            int.TryParse(txtLoonies.Text, out loonies);
            int.TryParse(txtQuarters.Text, out quarters);
            int.TryParse(txtDimes.Text, out dimes);
            int.TryParse(txtNickels.Text, out nickels);
            getDollarAmount(toonies, loonies, quarters, dimes, nickels);
            if (total.ToString().Substring(total.ToString().IndexOf(".") + 1).Length != 2)
            {
                txtOutput.Text = "$ " + total.ToString() + "0";
            }
            else
            {
                txtOutput.Text = "$ " + total.ToString();
            }
        }
    }
}
