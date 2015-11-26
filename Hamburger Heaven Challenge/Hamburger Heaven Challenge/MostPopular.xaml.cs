﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Hamburger_Heaven_Challenge.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MostPopular : Page
    {

        private ObservableCollection<Apartment> Apartments;

        
            public MostPopular()
            {
                this.InitializeComponent();
                Apartments = new ObservableCollection<Apartment>();
                ApartmentManager.GetAllApartments(Apartments);
            }



        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var apartment = (Apartment)e.ClickedItem;
            ApartmentResultTextBlock.Text = "You have selected apartment # " + apartment.ApartmentId;
        }



        // User refine the search by flyout buttons as follows:::

        private string _region;
        private string _roomNumber;
        private string _sortBy;


        private void Region_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _region = selected.Text;
            DisplayResult();
        }

        private void SortBy_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sortBy = selected.Text;
            DisplayResult();
        }

        private void RoomNumber_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roomNumber = selected.Text;
            DisplayResult();
        }
        private void DisplayResult()
        {
            if (_region == "None" || String.IsNullOrEmpty(_region))
            {
                ResultTextBlock.Text = "Please select a region";
                return;
            }

            ResultTextBlock.Text = _region;

            if (_sortBy != "None" && !String.IsNullOrEmpty(_sortBy))
                ResultTextBlock.Text += " + " + _sortBy;

            if (_roomNumber != "None" && !String.IsNullOrEmpty(_roomNumber))
                ResultTextBlock.Text += " + " + _roomNumber;


        }
    }
}

