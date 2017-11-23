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
    /// Interaction logic for CashorCheque.xaml
    /// </summary>
    public partial class CashorCheque : Page
    {
        string type;
        Account acc;
        public CashorCheque(string type, Account acc)
        {
            this.type = type;
            this.acc = acc;
            InitializeComponent();
        }

        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            Deposits p3 = new Deposits(this.type, this.acc);
            this.NavigationService.Navigate(p3);
        }

        private void Cheque_Click(object sender, RoutedEventArgs e)
        {
            Deposits p4 = new Deposits(this.type, this.acc);
            this.NavigationService.Navigate(p4);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ActionAccount p2 = new ActionAccount(this.type, this.acc);
            this.NavigationService.Navigate(p2);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage p1 = new WelcomePage();
            this.NavigationService.Navigate(p1);
        }
    }
}
