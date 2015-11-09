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
    public sealed partial class MostPopular : Page
    {
        public MostPopular()
        {
            this.InitializeComponent();
        }


        // User refine search by comboBox as follows:

        //private void ComboBox_RegionSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (RegionResultTextBlock == null) return;

        //    var combo = (ComboBox)sender;
        //    var item = (ComboBoxItem)combo.SelectedItem;
        //    RegionResultTextBlock.Text = item.Content.ToString();
        //}

        //private void ComboBox_SortBySelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (SortResultTextBlock == null) return;

        //    var combo = (ComboBox)sender;
        //    var item = (ComboBoxItem)combo.SelectedItem;
        //    SortResultTextBlock.Text = item.Content.ToString();
        //}

        //private void ComboBox_RoomsSelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (RoomsResultTextBlock == null) return;

        //    var combo = (ComboBox)sender;
        //    var item = (ComboBoxItem)combo.SelectedItem;
        //    RoomsResultTextBlock.Text = item.Content.ToString();
        //}



        // User refine the search by flyout buttons as follows:    

        private string _region;
        private string _roomNumber;
        private string _sortBy;


        private void Region_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _region = selected.Text;
            displayResult();
        }

        private void SortBy_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sortBy = selected.Text;
            displayResult();
        }

        private void RoomNumber_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roomNumber = selected.Text;
            displayResult();
        }
        private void displayResult()
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
