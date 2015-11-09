using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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
    public sealed partial class Profile : Page
    {

        private string profileName;
        private string password;
        private Dictionary<string, string> usersDictionary = new Dictionary<string, string>(); 

        MainPage page = new MainPage();

        public Profile()
        {
            this.InitializeComponent();
            usersDictionary.Add("Casper", "12345");
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            profileName = ProfileName.Text;
            password = PasswordBox.Password;

            if (usersDictionary.ContainsKey(profileName))
            {
                if (usersDictionary[profileName] == password)
                {
                    ProfileName.Text = "LOGIN SUCCES!";
                }
            }
            else
            {
                
            }
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            page.CreateUser();
        }
    }
}
