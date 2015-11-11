using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateUser : Page
    {
        // Fields for creating the account
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _passwordOne;
        private string _passwordTwo;
        public CreateUser()
        {
            this.InitializeComponent();
        }

        private void CreateUserButton_Click(object sender, RoutedEventArgs e)
        {

            FirstName.Background = new SolidColorBrush(Colors.White);
            LastName.Background = new SolidColorBrush(Colors.White);
            Email.Background = new SolidColorBrush(Colors.White);
            PasswordOne.Background = new SolidColorBrush(Colors.White);
            PasswordTwo.Background = new SolidColorBrush(Colors.White);

            if (FirstName.Text != "" && LastName.Text != "" && Email.Text != "" && PasswordOne.Password != "")
            {
                if (PasswordOne.Password != PasswordTwo.Password)
                {
                    PasswordOne.Background = new SolidColorBrush(Colors.Red);
                    PasswordTwo.Background = new SolidColorBrush(Colors.Red);

                    PasswordOne.PlaceholderText = "Passwords must match";
                    PasswordTwo.PlaceholderText = "Passwords must match";
                }
                else
                {
                    FirstName.Text = "It works";
                    if (Email.Text.Contains("@"))
                    {
                        // do whatever to do
                    }
                    else
                    {
                        Email.Background = new SolidColorBrush(Colors.Red);
                    }
                }
            }
            else if (FirstName.Text == "")
            {
                FirstName.Background = new SolidColorBrush(Colors.Red);
            }
            else if (LastName.Text == "")
            {
                LastName.Background = new SolidColorBrush(Colors.Red);
            }
            else if (Email.Text == "")
            {
                Email.Background = new SolidColorBrush(Colors.Red);
            }
            else if (PasswordOne.Password == "")
            {
                PasswordOne.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
