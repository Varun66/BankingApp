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
    /// Interaction logic for SwipeFail.xaml
    /// </summary>
    public partial class SwipeFail : Page
    {
        int size;
        public SwipeFail()
        {
            InitializeComponent();
            size = 0;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            e.Handled = true;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Welcome_Page p1 = new Welcome_Page();
            this.NavigationService.Navigate(p1);
        }

        private void click_button(object sender, RoutedEventArgs e)
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
            if (textbox_pin.Text.Equals("1234"))
            {
                Account_Management p2 = new Account_Management();
                this.NavigationService.Navigate(p2);
            }
            else
            {
                Pin_Error p3 = new Pin_Error();
                this.NavigationService.Navigate(p3);
            }
        }

        private void Correction_click(object sender, RoutedEventArgs e)
        {
            textbox_pin.Text = textbox_pin.Text.Remove(size-1);
            size--;
        }

        private void Cancel_click(object sender, RoutedEventArgs e)
        {
            textbox_pin.Text = String.Empty;
            size = 0;
        }
    }


}

