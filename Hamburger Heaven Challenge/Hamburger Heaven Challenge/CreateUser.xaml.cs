using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
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

        public CreateUser()
        {
            this.InitializeComponent();
        }

        private async void CreateUserButton_Click(object sender, RoutedEventArgs e)
        {

            FirstName.Background = new SolidColorBrush(Colors.White);
            LastName.Background = new SolidColorBrush(Colors.White);
            Email.Background = new SolidColorBrush(Colors.White);
            PasswordOne.Background = new SolidColorBrush(Colors.White);
            PasswordTwo.Background = new SolidColorBrush(Colors.White);

            if (FirstName.Text != "" && LastName.Text != "" && Email.Text != "" && PasswordOne.Password != "")
            {

                // Check if the passwords match

                if (PasswordOne.Password != PasswordTwo.Password)
                {
                    PasswordOne.Background = new SolidColorBrush(Colors.Red);
                    PasswordTwo.Background = new SolidColorBrush(Colors.Red);

                    PasswordOne.PlaceholderText = "Passwords must match";
                    PasswordTwo.PlaceholderText = "Passwords must match";
                }
                else
                {
                    // Check if Email contains a @ e.g. is a valid email. This should be done properly
                    // but is done like this.
                    if (Email.Text.Contains("@"))
                    {
                        // Now all fields are filled, passwords match and the email is valid
                        _firstName = FirstName.Text;
                        _lastName = LastName.Text;
                        _email = Email.Text;
                        _passwordOne = PasswordOne.Password;

                        try
                        {
                            StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/Users.txt"));

                            await file.CopyAsync(ApplicationData.Current.LocalFolder, "Users.txt");

                            StorageFolder localFolder = ApplicationData.Current.LocalFolder;

                            var files = await localFolder.GetFilesAsync();

                            foreach (StorageFile storageFile in files)
                            {
                                if (storageFile.Name == "Users.txt")
                                {
                                    var oldFileContent = File.ReadAllText(storageFile.Path);

                                    var newFileContent = oldFileContent + _firstName + " | " + _lastName + " | " +
                                                         _email +
                                                         " | " + _passwordOne + Environment.NewLine;
                                    File.WriteAllText(storageFile.Path, newFileContent);
                                }
                            }
                        }
                        catch
                        {

                            StorageFolder localFolder = ApplicationData.Current.LocalFolder;

                            var files = await localFolder.GetFilesAsync();

                            foreach (StorageFile storageFile in files)
                            {
                                if (storageFile.Name == "Users.txt")
                                {
                                    var oldFileContent = File.ReadAllText(storageFile.Path);

                                    var newFileContent = oldFileContent + _firstName + " | " + _lastName + " | " +
                                                         _email +
                                                         " | " + _passwordOne + Environment.NewLine;
                                    File.WriteAllText(storageFile.Path, newFileContent);
                                }
                            }
                        }

                        // TODO: We have to implement a file in assets that we copy into localpath
                    }
                    else
                    {
                        Email.Background = new SolidColorBrush(Colors.Red);
                    }
                }
            }

            // Check if any of the fields are blank

            if (FirstName.Text == "")
            {
                FirstName.Background = new SolidColorBrush(Colors.Red);
            }
            if (LastName.Text == "")
            {
                LastName.Background = new SolidColorBrush(Colors.Red);
            }
            if (Email.Text == "")
            {
                Email.Background = new SolidColorBrush(Colors.Red);
            }
            if (PasswordOne.Password == "")
            {
                PasswordOne.Background = new SolidColorBrush(Colors.Red);
            }
            if (PasswordTwo.Password == "")
            {
                PasswordTwo.Background = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
