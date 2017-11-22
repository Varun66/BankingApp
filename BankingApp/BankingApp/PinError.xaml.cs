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
    /// Interaction logic for Pin_Error.xaml
    /// </summary>
    public partial class PinError : Page
    {
        public PinError()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = true;
        }

        private void Return_click(object sender, RoutedEventArgs e)
        {
            SwipeFail p1 = new SwipeFail();
            this.NavigationService.Navigate(p1);
        }

        private void Exit_click(object sender, RoutedEventArgs e)
        {
            WelcomePage p2 = new WelcomePage();
            this.NavigationService.Navigate(p2);
        }
    }
}
