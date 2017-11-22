﻿using System;
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
        string type;
        public ActionAccount(string type)
        {
            this.type = type;
            InitializeComponent();

        }
       

        private void Withdrawal_click(object sender, RoutedEventArgs e)
        {
           Withdrawal p1 = new Withdrawal();
            this.NavigationService.Navigate(p1);
        }

        private void Deposits_click(object sender, RoutedEventArgs e)
        {
           Deposits p2 = new Deposits();
            this.NavigationService.Navigate(p2);
        }

        private void Check_click(object sender, RoutedEventArgs e)
        {
            CheckBalance p3 = new CheckBalance();
            this.NavigationService.Navigate(p3);
        }

        private void Transfers_click(object sender, RoutedEventArgs e)
        {
           Transfers p4 = new Transfers();
            this.NavigationService.Navigate(p4);
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage p5 = new WelcomePage();
            this.NavigationService.Navigate(p5);
        }
    }
}