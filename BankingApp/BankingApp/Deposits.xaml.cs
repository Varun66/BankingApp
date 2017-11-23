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
    /// Interaction logic for Deposits.xaml
    /// </summary>
    public partial class Deposits : Page
    {
        public Deposits()
        {
            InitializeComponent();
        }

        private void twenty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void hundred_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fifty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void twohundred_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Other_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage p1 = new WelcomePage();
            this.NavigationService.Navigate(p1);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           // ActionAccount p2 = new ActionAccount("Checking");
            //this.NavigationService.Navigate(p2);
        }
    }
}
