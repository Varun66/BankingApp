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
    /// Interaction logic for Transfers.xaml
    /// </summary>
    public partial class Transfers : Page
    {
        string type;
        Account acc;
        public Transfers(string type, Account acc)
        {
            this.type = type;
            this.acc = acc;
            InitializeComponent();
        }

        private void twenty_Click(object sender, RoutedEventArgs e)
        {
            int current1 = this.acc.CheckingTotal;
            int current2 = this.acc.SavingsTotal;
            if (current1 - 20 >= 0 && current2 +20<=5000)
            {
                this.acc.CheckingTotal = current1 - 20;
                this.acc.changeBalance("Withdrawal (Transfer from) of 20 $CAD", "Checking");
                this.acc.SavingsTotal = current2 + 20;
                this.acc.changeBalance("Deposit (Transfer to) of 20 $CAD", "Savings");
                Sucess p3 = new Sucess(this.type, this.acc);
                this.NavigationService.Navigate(p3);
            }
            else if(current1 -20<0)
            {
                InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                this.NavigationService.Navigate(p4);
            }
            else if(current2 + 20 > 5000)
            {
                ExceedLimit p4 = new ExceedLimit(this.type, this.acc);
                this.NavigationService.Navigate(p4);
            }
        }
            
        

        private void hundred_Click(object sender, RoutedEventArgs e)
        {
        int current1 = this.acc.CheckingTotal;
        int current2 = this.acc.SavingsTotal;
        if (current1 - 100 >= 0 && current2 + 100 <= 5000)
        {
            this.acc.CheckingTotal = current1 - 100;
            this.acc.changeBalance("Withdrawal (Transfer from) of 100 $CAD", "Checking");
            this.acc.SavingsTotal = current2 + 100;
            this.acc.changeBalance("Deposit (Transfer to) of 100 $CAD", "Savings");
            Sucess p3 = new Sucess(this.type, this.acc);
            this.NavigationService.Navigate(p3);
        }
        else if (current1 - 100 < 0)
        {
            InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
            this.NavigationService.Navigate(p4);
        }
        else if (current2 + 100 > 5000)
        {
            ExceedLimit p4 = new ExceedLimit(this.type, this.acc);
            this.NavigationService.Navigate(p4);
        }
    
}

        private void fifty_Click(object sender, RoutedEventArgs e)
        {
              int current1 = this.acc.CheckingTotal;
            int current2 = this.acc.SavingsTotal;
            if (current1 - 50 >= 0 && current2 +50<=5000)
            {
                this.acc.CheckingTotal = current1 - 50;
                this.acc.changeBalance("Withdrawal (Transfer from) of 50 $CAD", "Checking");
                this.acc.SavingsTotal = current2 + 50;
                this.acc.changeBalance("Deposit (Transfer to) of 50 $CAD", "Savings");
                Sucess p3 = new Sucess(this.type, this.acc);
                this.NavigationService.Navigate(p3);
            }
            else if(current1 -50<0)
            {
                InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                this.NavigationService.Navigate(p4);
            }
            else if(current2 + 50 > 5000)
            {
                ExceedLimit p4 = new ExceedLimit(this.type, this.acc);
                this.NavigationService.Navigate(p4);
            }
        
        }

        private void twohundred_Click(object sender, RoutedEventArgs e)
        {
            int current1 = this.acc.CheckingTotal;
            int current2 = this.acc.SavingsTotal;
            if (current1 - 200 >= 0 && current2 + 200 <= 5000)
            {
                this.acc.CheckingTotal = current1 - 200;
                this.acc.changeBalance("Withdrawal (Transfer from) of 200 $CAD", "Checking");
                this.acc.SavingsTotal = current2 + 200;
                this.acc.changeBalance("Deposit (Transfer to) of 200 $CAD", "Savings");
                Sucess p3 = new Sucess(this.type, this.acc);
                this.NavigationService.Navigate(p3);
            }
            else if (current1 - 200 < 0)
            {
                InsuffFunds p4 = new InsuffFunds(this.type, this.acc);
                this.NavigationService.Navigate(p4);
            }
            else if (current2 + 200 > 5000)
            {
                ExceedLimit p4 = new ExceedLimit(this.type, this.acc);
                this.NavigationService.Navigate(p4);
            }
        
    }

        private void Other_Click(object sender, RoutedEventArgs e)
        {
            OtherTransfer p5 = new OtherTransfer(this.type, this.acc);
            this.NavigationService.Navigate(p5);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            ActionAccount p6 = new ActionAccount(this.type, this.acc);
            this.NavigationService.Navigate(p6);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage p1 = new WelcomePage();
            this.NavigationService.Navigate(p1);
        }
    }
}
