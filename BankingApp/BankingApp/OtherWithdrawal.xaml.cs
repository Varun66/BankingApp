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
    /// Interaction logic for OtherDeposit.xaml
    /// </summary>
    public partial class OtherWithdrawal : Page
    {
        string type;
        Account acc;
        int size;
        public OtherWithdrawal(string type, Account acc)
        {
            this.type = type;
            this.acc = acc;
            InitializeComponent();
            size = 0;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = true;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage p1 = new WelcomePage();
            this.NavigationService.Navigate(p1);
        }

        private void Back_Click_1(object sender, RoutedEventArgs e)
        {
            ActionAccount p2 = new ActionAccount(this.type, this.acc);
            this.NavigationService.Navigate(p2);
        }
        private void Button_click(object sender, RoutedEventArgs e)
        {

            Button button = (Button)sender;

            if (size < 4)
            {
                if (size == 0)
                {
                    textbox_pin.Text = String.Empty;
                }
                textbox_pin.Text = textbox_pin.Text + button.Content;
                size++;
            }

        }

        private void Confirm_click(object sender, RoutedEventArgs e)
        {
            if (this.type.Equals("Checking") && Int32.Parse(textbox_pin.Text) <= 5000)
            {
                int current = this.acc.CheckingTotal;

                this.acc.CheckingTotal = current - Int32.Parse(textbox_pin.Text);
                this.acc.changeBalance("Withdrawal of " + textbox_pin.Text + " $CAD", this.type);
                Sucess p3 = new Sucess(this.type, this.acc);
                this.NavigationService.Navigate(p3);


            }

            else if (this.type.Equals("Savings") && Int32.Parse(textbox_pin.Text) <= 5000)
            {
                int current = this.acc.CheckingTotal;

                this.acc.CheckingTotal = current - Int32.Parse(textbox_pin.Text);
                this.acc.changeBalance("Withdrawal of " + textbox_pin.Text + " $CAD", this.type);
                Sucess p3 = new Sucess(this.type, this.acc);
                this.NavigationService.Navigate(p3);


            }

            else if (this.acc.CheckingTotal-Int32.Parse(textbox_pin.Text) < 0)
            {
                InsuffFunds p2 = new InsuffFunds(this.type, this.acc);
                this.NavigationService.Navigate(p2);
            }
        }

        private void Correction_click(object sender, RoutedEventArgs e)
        {
            if (size != 0)
            {
                textbox_pin.Text = textbox_pin.Text.Remove(size - 1);
                size--;
            }
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            textbox_pin.Text = String.Empty;
            size = 0;
        }
    }
}
