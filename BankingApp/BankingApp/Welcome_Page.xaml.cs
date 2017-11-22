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
    public partial class Welcome_Page : Page
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Insert_Card_U1_Pass_Click(object sender, RoutedEventArgs e)
        {
            Account_Management p2 = new Account_Management();
            this.NavigationService.Navigate(p2);
            
            
        }

        private void Insert_Card_U1_Fail_Click(object sender, RoutedEventArgs e)
        {
            Account_Management p2 = new Account_Management();
            this.NavigationService.Navigate(p2);
        }
    }
}
