using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
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
    public sealed partial class MyProfile : Page
    {

        private string _adress;
        private string _city;
        private string _country;
        private long _cardNumber;
        private string _expiryDate;
        private int _securityNumber;

        private string _email;

        public MyProfile()
        {
            this.InitializeComponent();

            _email = _email + ".txt";
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //this.DataContext = e.Parameter;
            _email = (string)e.Parameter;
            _email = _email + ".txt";

        }

        private async void Save_Click(object sender, RoutedEventArgs e)
        {

            CardNumber.Background = new SolidColorBrush(Colors.White);
            SecurityNum.Background = new SolidColorBrush(Colors.White);

            _adress = Adress.Text;
            _city = City.Text;
            _country = Country.Text;

            try
            {
                if (CardNumber.Text.Length != 16)
                {
                    CardNumber.Background = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    _cardNumber = Convert.ToInt64(CardNumber.Text);
                }
            }
            catch
            {
                CardNumber.Background = new SolidColorBrush(Colors.Red);
            }

            _expiryDate = ExpiryDate.Date.ToString("d");

            try
            {
                if (SecurityNum.Text.Length != 3)
                {
                    SecurityNum.Background = new SolidColorBrush(Colors.Red);
                }
                else
                {
                    _securityNumber = Convert.ToInt16(SecurityNum.Text);
                }
            }
            catch
            {
                SecurityNum.Background = new SolidColorBrush(Colors.Red);
            }

            try
            {
                Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
                Windows.Storage.StorageFile sampleFile = await storageFolder.CreateFileAsync(_email, Windows.Storage.CreationCollisionOption.ReplaceExisting);

                StorageFolder localFolder = ApplicationData.Current.LocalFolder;

                var files = await localFolder.GetFilesAsync();

                foreach (StorageFile storageFile in files)
                {
                    if (storageFile.Name == _email)
                    {
                        var newFileContent = "--- Adress: --- \r\n" + _adress + "\r\n" + _city + "\r\n" + _country + "\r\n" + "--- Creditcard Information: ---- \r\n" + _cardNumber + "\r\n" + _expiryDate + "\r\n" + _securityNumber;
                        File.WriteAllText(storageFile.Path, newFileContent);

                        Adress.Text = "";
                        City.Text = "";
                        Country.Text = "";

                        CardNumber.Text = "";
                        SecurityNum.Text = "";

                        MessageDialog message = new MessageDialog("Your data was saved!");
                        await message.ShowAsync();
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
                        var newFileContent = "--- Adress: --- \r\n" + _adress + "\r\n" + _city + "\r\n" + _country + "\r\n" + "--- Creditcard Information: ---- \r\n" + _cardNumber + "\r\n" + _expiryDate + "\r\n" + _securityNumber;
                        File.WriteAllText(storageFile.Path, newFileContent);

                        Adress.Text = "";
                        City.Text = "";
                        Country.Text = "";

                        CardNumber.Text = "";
                        SecurityNum.Text = "";

                        MessageDialog message = new MessageDialog("Your data was saved!");
                        await message.ShowAsync();

                    }
                }
            }
        }
    }
}
