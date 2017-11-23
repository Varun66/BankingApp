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
    /// Interaction logic for Withdrawal.xaml
    /// </summary>
    public partial class Withdrawal : Page
    {
        string type;
        Account acc;
        public Withdrawal(string type, Account acc)
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

        private void twenty_Click(object sender, RoutedEventArgs e)
        {
            if (this.type.Equals("Checking"))
            {
                int current = this.acc.CheckingTotal;
                if (current - 20 >= 0)
                {
                    this.acc.CheckingTotal = current - 20;
                    this.acc.changeBalance("Withdrawal of 20 $CAD", this.type);
                    Sucess p3 = new Sucess(this.type, this.acc);
                    this.NavigationService.Navigate(p3);
                }
                else
                {
                    InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                    this.NavigationService.Navigate(p4);
                }
                
            }
            else if (this.type.Equals("Savings"))
            {
                int current = this.acc.SavingsTotal;
                if (current - 20 >= 0)
                {
                    this.acc.SavingsTotal = current - 20;
                    this.acc.changeBalance("Withdrawal of 20 $CAD", this.type);
                    Sucess p3 = new Sucess(this.type, this.acc);
                    this.NavigationService.Navigate(p3);
                }
                else
                {
                    InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                    this.NavigationService.Navigate(p4);
                }
            }
            
           
        }

        private void fifty_Click(object sender, RoutedEventArgs e)
        {
            if (this.type.Equals("Checking"))
            {
                int current = this.acc.CheckingTotal;
                if (current - 50 >= 0)
                {
                    this.acc.CheckingTotal = current - 50;
                    this.acc.changeBalance("Withdrawal of 50 $CAD", this.type);
                    Sucess p3 = new Sucess(this.type, this.acc);
                    this.NavigationService.Navigate(p3);
                }
                else
                {
                    InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                    this.NavigationService.Navigate(p4);
                }

            }
            else if (this.type.Equals("Savings"))
            {
                int current = this.acc.SavingsTotal;
                if (current - 50 >= 0)
                {
                    this.acc.SavingsTotal = current - 50;
                    this.acc.changeBalance("Withdrawal of 50 $CAD", this.type);
                    Sucess p3 = new Sucess(this.type, this.acc);
                    this.NavigationService.Navigate(p3);
                }
                else
                {
                    InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                    this.NavigationService.Navigate(p4);
                }
            }
        }

        private void hundred_Click(object sender, RoutedEventArgs e)
        {
            if (this.type.Equals("Checking"))
            {
                int current = this.acc.CheckingTotal;
                if (current - 100 >= 0)
                {
                    this.acc.CheckingTotal = current -100;
                    this.acc.changeBalance("Withdrawal of 100 $CAD", this.type);
                    Sucess p3 = new Sucess(this.type, this.acc);
                    this.NavigationService.Navigate(p3);
                }
                else
                {
                    InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                    this.NavigationService.Navigate(p4);
                }

            }
            else if (this.type.Equals("Savings"))
            {
                int current = this.acc.SavingsTotal;
                if (current - 100 >= 0)
                {
                    this.acc.SavingsTotal = current - 100;
                    this.acc.changeBalance("Withdrawal of 100 $CAD", this.type);
                    Sucess p3 = new Sucess(this.type, this.acc);
                    this.NavigationService.Navigate(p3);
                }
                else
                {
                    InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                    this.NavigationService.Navigate(p4);
                }
            }
        }

        private void twohundred_Click(object sender, RoutedEventArgs e)
        {
            if (this.type.Equals("Checking"))
            {
                int current = this.acc.CheckingTotal;
                if (current - 200 >= 0)
                {
                    this.acc.CheckingTotal = current - 200;
                    this.acc.changeBalance("Withdrawal of 200 $CAD", this.type);
                    Sucess p3 = new Sucess(this.type, this.acc);
                    this.NavigationService.Navigate(p3);
                }
                else
                {
                    InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                    this.NavigationService.Navigate(p4);
                }

            }
            else if (this.type.Equals("Savings"))
            {
                int current = this.acc.SavingsTotal;
                if (current - 200 >= 0)
                {
                    this.acc.SavingsTotal = current - 200;
                    this.acc.changeBalance("Withdrawal of 200 $CAD", this.type);
                    Sucess p3 = new Sucess(this.type, this.acc);
                    this.NavigationService.Navigate(p3);
                }
                else
                {
                    InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                    this.NavigationService.Navigate(p4);
                }
            }
        }

        private void Other_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
