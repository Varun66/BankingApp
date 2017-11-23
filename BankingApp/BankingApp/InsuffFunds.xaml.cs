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

namespace BankingApp
{
    /// <summary>
    /// Interaction logic for InsuffFunds.xaml
    /// </summary>
    public partial class InsuffFunds : Page
    {
        Account acc;
        string type;
        public InsuffFunds(string type, Account acc)
        {
            this.type = type;
            this.acc = acc;

            InitializeComponent();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage p1 = new WelcomePage();
            this.NavigationService.Navigate(p1);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ActionAccount p2 = new ActionAccount(this.type, this.acc);
            this.NavigationService.Navigate(p2);
        }
    }
}
