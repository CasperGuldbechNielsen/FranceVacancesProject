using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Popups;
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

        public delegate void MyEventHandler(object source, RoutedEventArgs e);
        public delegate void MyEventHandlerTwo(object source, RoutedEventArgs e, string email);

        public event MyEventHandler OnNavigateParentReady;
        public event MyEventHandlerTwo OnNavigateLogin;

        private string _profileName;
        private string _password;

        private bool _correctUser = false;
        private bool _correctPass = false;

        public Profile()
        {
            this.InitializeComponent();
            
        }

        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            _profileName = ProfileName.Text;
            _password = PasswordBox.Password;
            if (_profileName != "" && _password != "")
            {
                StorageFolder localFolder = ApplicationData.Current.LocalFolder;

                var files = await localFolder.GetFilesAsync();

                foreach (StorageFile storageFile in files)
                {
                    if (storageFile.Name == "Users.txt")
                    {
                        var read = await FileIO.ReadLinesAsync(storageFile);

                        foreach (var line in read)
                        {
                            string[] profileInfo = line.Split('|');

                            if (profileInfo[2].Contains(_profileName))
                            {
                                _correctUser = true;
                                if (profileInfo[3].Contains(_password))
                                {
                                    _correctPass = true;
                                }
                               
                            }

                        }
                        if (_correctUser)
                        {

                            if (_correctPass)
                            {
                                if (OnNavigateLogin != null)
                                {
                                    OnNavigateLogin(sender, e, _profileName);
                                    break;
                                }
                            }
                            else
                            {
                                var message = new MessageDialog("Wrong password", "Error");

                                await message.ShowAsync();

                                PasswordBox.Password = "";

                                break;
                            }
                        }
                        else
                        {
                            var message = new MessageDialog("User does not exist!", "Error");

                            await message.ShowAsync();

                            ProfileName.Text = "";
                            PasswordBox.Password = "";

                            break;
                        }
                    }
                }
            }
            else
            {
                
            }
        }

        private void CreateUser_Click(object sender, RoutedEventArgs e)
        {
            if(OnNavigateParentReady != null)
            { 
                OnNavigateParentReady(sender, e);
            }
        }
    }
}
