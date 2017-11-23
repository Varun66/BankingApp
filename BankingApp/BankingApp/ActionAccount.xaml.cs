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
    /// Interaction logic for Action_Account.xaml
    /// </summary>
    public partial class ActionAccount : Page
    {
        Account acc;
        string type;
        public ActionAccount(string type, Account acc)
        {
            this.type = type;
            this.acc = acc;
            InitializeComponent();

        }
       

        private void Withdrawal_click(object sender, RoutedEventArgs e)
        {
           Withdrawal p1 = new Withdrawal(this.type, this.acc);
            this.NavigationService.Navigate(p1);
        }

        private void Deposits_click(object sender, RoutedEventArgs e)
        {
           CashorCheque p2 = new CashorCheque(this.type, this.acc);
           this.NavigationService.Navigate(p2);
        }

        private void Check_click(object sender, RoutedEventArgs e)
        {
           // CheckBalance p3 = new CheckBalance(this.type,  this.acc);
            //this.NavigationService.Navigate(p3);
        }

        private void Transfers_click(object sender, RoutedEventArgs e)
        {
          // Transfers p4 = new Transfers( this.type, this.acc);
           // this.NavigationService.Navigate(p4);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage p5 = new WelcomePage();
            this.NavigationService.Navigate(p5);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AccountManagement p6 = new AccountManagement(this.acc);
            this.NavigationService.Navigate(p6);
        }
    }
}
