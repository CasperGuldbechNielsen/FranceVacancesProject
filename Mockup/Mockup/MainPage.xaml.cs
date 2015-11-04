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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Mockup
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof (HomePage));
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void HomeButton_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(HomePage));
        }

        private void LocationsButton_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof (Locations));
        }

        private void MostPopularButton_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(MostPopular));
        }

        private void MapButton_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Map));
        }

        private void ProfileButton_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Profile));
        }

        private void ContactButton_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(Contact));
        }
    }
}
