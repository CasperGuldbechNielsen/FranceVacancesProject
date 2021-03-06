﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public delegate void MyEventHandler(object source, RoutedEventArgs e, string city);

        public event MyEventHandler NavigateToResults;
        
        private ObservableCollection<Apartment> apartments;
        private List<String> Suggestions;

        private string city;
        private int rooms;

        ApartmentManager myManaApartmentManger = new ApartmentManager();

        public Home()
        {
            this.InitializeComponent();
            //MyMap.Center = new Geopoint(new BasicGeoposition() { Latitude = 46.8442643, Longitude = 2.5992004 });
            //MyMap.ZoomLevel = 6;
            apartments = new ObservableCollection<Apartment>();
            myManaApartmentManger.GetAllApartments(apartments);
        }

        private void AutoSuggestBox_OnTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            myManaApartmentManger.GetAllApartments(apartments);
            Suggestions = apartments
                .Where(p => p.ApartmentCity.ToString().ToLower().StartsWith(sender.Text))
                .Select(p => p.ApartmentCity.ToString()).Distinct()
                .ToList();
            AutoSuggestBox.ItemsSource = Suggestions;


        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            city = AutoSuggestBox.Text;

            if (NavigateToResults != null)
            {
                NavigateToResults(sender, e, city);
            }
        }
    }
}
