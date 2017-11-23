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
    /// Interaction logic for CheckBalance.xaml
    /// </summary>
    public partial class CheckBalance : Page
    {
        string type;
        Account acc;

        public CheckBalance(string type, Account acc)
        {
            this.type = type;
            this.acc = acc;
            InitializeComponent();
            if (type.Equals("Checking"))
            {
                listBox.Items.Add("TOTAL:" + this.acc.CheckingTotal.ToString());
                foreach (string item in this.acc.CheckingBalance)
                {
                    listBox.Items.Add(item);
                }
             
                

            }
            else
            {

                listBox.Items.Add("TOTAL:" + this.acc.SavingsTotal.ToString());
                foreach (string item in this.acc.SavingsBalance)
                {
                    listBox.Items.Add(item);
                }
            }
            for (int i = 0; i < listBox.Items.Count / 2; i++)
            {
                var tmp = listBox.Items[i];
                listBox.Items[i] = listBox.Items[listBox.Items.Count - i - 1];
                listBox.Items[listBox.Items.Count - i - 1] = tmp;
            }



        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            WelcomePage p1 = new WelcomePage();
            this.NavigationService.Navigate(p1);
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
           ActionAccount p2 = new ActionAccount(this.type,this.acc);
           this.NavigationService.Navigate(p2);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}
