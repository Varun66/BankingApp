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
    /// Interaction logic for Welcome_Page.xaml
    /// </summary>
    public partial class WelcomePage : Page
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

   

        private void Insert_Card_U1_Pass_Click(object sender, RoutedEventArgs e)
        {
            Account acc = new Account("1234");
            AccountManagement p2 = new AccountManagement(acc);
            this.NavigationService.Navigate(p2);
            
            
        }

        private void Insert_Card_U1_Fail_Click(object sender, RoutedEventArgs e)
        {
            Account acc = new Account("1234");
            SwipeFail p3 = new SwipeFail(acc);
            this.NavigationService.Navigate(p3);
        }

        private void Insert_Card_U2_Pass_Click(object sender, RoutedEventArgs e)
        {
            Account acc = new Account("5678");
            AccountManagement p2 = new AccountManagement(acc);
            this.NavigationService.Navigate(p2);
        }

        private void Insert_Card_U2_Fail_Click(object sender, RoutedEventArgs e)
        {
            Account acc = new Account("5678");
            SwipeFail p3 = new SwipeFail(acc);
            this.NavigationService.Navigate(p3);
        }
    }
}
