using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
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

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Financial));
            BackButton.Visibility = Visibility.Collapsed;
            Title.Margin = new Thickness(68,0,0,0);
        }

        private void IconsLIstBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeListItem.IsSelected)
            {
                MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Financial));
                Title.Text = "Home";
                BackButton.Visibility = Visibility.Visible;
                if (!MyFrame.CanGoBack)
                {
                    BackButton.Visibility = Visibility.Collapsed;
                    Title.Margin = new Thickness(68, 0, 0, 0);
                }

            }
            else if (LocationsListBoxItem.IsSelected)
            {
                MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Food));
                Title.Text = "Locations";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);
            }
            else if (MostPopularListBoxItem.IsSelected)
            {
                MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(MostPopular));
                Title.Text = "Most Popular";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);
            }
            else if (MapListBoxItem.IsSelected)
            {
                MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Map));
                Title.Text = "Map";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);
            }
            else if (ProfileListBoxItem.IsSelected)
            {
                MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Profile));
                Title.Text = "Profile";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);
            }
            else if (ContactListBoxItem.IsSelected)
            {
                MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Contact));
                Title.Text = "Contact";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);
            }
        }

        private void HamburgerButton_OnClick(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();

                if (MyFrame.CurrentSourcePageType == typeof (Financial))
                {
                    Title.Text = "Home";
                    HomeListItem.IsSelected = true;
                    if (MyFrame.CanGoBack)
                        MyFrame.GoBack();
                    if (!MyFrame.CanGoBack)
                    {
                        BackButton.Visibility = Visibility.Collapsed;
                        Title.Margin = new Thickness(68, 0, 0, 0);
                    }
                }
                else if (MyFrame.CurrentSourcePageType == typeof (Food))
                {
                    Title.Text = "Locations";
                    LocationsListBoxItem.IsSelected = true;
                    if (MyFrame.CanGoBack)
                        MyFrame.GoBack();
                }
                else if (MyFrame.CurrentSourcePageType == typeof (MostPopular))
                {
                    Title.Text = "Most Popular";
                    MostPopularListBoxItem.IsSelected = true;
                    if (MyFrame.CanGoBack)
                        MyFrame.GoBack();
                }
                else if (MyFrame.CurrentSourcePageType == typeof(Map))
                {
                    Title.Text = "Map";
                    MapListBoxItem.IsSelected = true;
                    if (MyFrame.CanGoBack)
                        MyFrame.GoBack();
                }
                else if (MyFrame.CurrentSourcePageType == typeof(Profile))
                {
                    Title.Text = "Profile";
                    ProfileListBoxItem.IsSelected = true;
                    if (MyFrame.CanGoBack)
                        MyFrame.GoBack();
                }
                else if (MyFrame.CurrentSourcePageType == typeof(Contact))
                {
                    Title.Text = "Contact";
                    ContactListBoxItem.IsSelected = true;
                    if (MyFrame.CanGoBack)
                        MyFrame.GoBack();
                } 

            }
        }

        public void CreateUser()
        {
            if (MySplitView.Content != null)
                ((Frame)MySplitView.Content).Navigate(typeof(CreateUser));
            Title.Text = "Create User";
            BackButton.Visibility = Visibility.Visible;
        }
    }
}
