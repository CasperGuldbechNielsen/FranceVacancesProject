using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Hamburger_Heaven_Challenge.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Home : Page
    {
        private string[] frenchCities = new string[] {"Paris", "Lyon", "Nice", "Antibes", "Pardour", "Lille" };

        public Home()
        {
            this.InitializeComponent();
            //MyMap.Center = new Geopoint(new BasicGeoposition() { Latitude = 46.8442643, Longitude = 2.5992004 });
            //MyMap.ZoomLevel = 6;
        }

        private void AutoSuggestBox_OnTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox) sender;
            var filtered = frenchCities.Where(P => P.StartsWith((autoSuggestBox.Text), StringComparison.CurrentCultureIgnoreCase)).ToArray();
            autoSuggestBox.ItemsSource = filtered;

            
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            SearchResult searchResult = new SearchResult();
        }
    }
}
