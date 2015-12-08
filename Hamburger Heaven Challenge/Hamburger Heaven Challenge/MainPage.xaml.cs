using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.Foundation;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Hamburger_Heaven_Challenge.Models;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<Apartment> apartments;
        private List<String> Suggestions;

        public MainPage()
        {
            this.InitializeComponent();
            MyFrame.Navigate(typeof(Home));
            BackButton.Visibility = Visibility.Collapsed;
            Title.Margin = new Thickness(68,0,0,0);

            // Populates the observable collection 'Apartment'
            apartments = new ObservableCollection<Apartment>();
            ApartmentManager.GetAllApartments(apartments);
        }

        private void IconsLIstBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (HomeListItem.IsSelected)
            {
                //MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Home));
                Title.Text = "Home";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);
                if (!MyFrame.CanGoBack)
                {
                    BackButton.Visibility = Visibility.Collapsed;
                    Title.Margin = new Thickness(68, 0, 0, 0);
                }

                if(stategroup.CurrentState == NoUI || stategroup.CurrentState == compact)
                {
                    MySplitView.IsPaneOpen = false;
                }

            }
            else if (LocationsListBoxItem.IsSelected)
            {
             //   MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Locations));
                Title.Text = "Locations";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);

                if (stategroup.CurrentState == NoUI || stategroup.CurrentState == compact)
                {
                    MySplitView.IsPaneOpen = false;
                }
            }
            else if (MostPopularListBoxItem.IsSelected)
            {
            //    MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(MostPopular));
                Title.Text = "Most Popular";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);

                if (stategroup.CurrentState == NoUI || stategroup.CurrentState == compact)
                {
                    MySplitView.IsPaneOpen = false;
                }
            }
            else if (MapListBoxItem.IsSelected)
            {
            //    MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Map));
                Title.Text = "Map";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);

                if (stategroup.CurrentState == NoUI || stategroup.CurrentState == compact)
                {
                    MySplitView.IsPaneOpen = false;
                }
            }
            else if (ProfileListBoxItem.IsSelected)
            {
             //   MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Profile));
                Title.Text = "Profile";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);

                var a = (Profile)MyFrame.Content;
                if (a != null) 
                    a.OnNavigateParentReady += OnCreateUser;

                var b = (Profile)MyFrame.Content;
                if (b != null)
                    b.OnNavigateLogin += OnLogin;
                if (stategroup.CurrentState == NoUI || stategroup.CurrentState == compact)
                {
                    MySplitView.IsPaneOpen = false;
                }

            }
            else if (ContactListBoxItem.IsSelected)
            {
               // MySplitView.IsPaneOpen = false;
                if (MySplitView.Content != null)
                    ((Frame)MySplitView.Content).Navigate(typeof(Contact));
                Title.Text = "Contact";
                BackButton.Visibility = Visibility.Visible;
                Title.Margin = new Thickness(0, 0, 0, 0);

                if (stategroup.CurrentState == NoUI || stategroup.CurrentState == compact)
                {
                    MySplitView.IsPaneOpen = false;
                }
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

                if (MyFrame.CurrentSourcePageType == typeof (CreateUser))
                {
                    MyFrame.GoBack();
                    Title.Text = "Profile";
                    ProfileListBoxItem.IsSelected = true;
                    var a = (Profile)MyFrame.Content;
                    if (a != null)
                        a.OnNavigateParentReady += OnCreateUser;

                    var b = (Profile)MyFrame.Content;
                    if (b != null)
                        b.OnNavigateLogin += OnLogin;
                }
                else if (MyFrame.CurrentSourcePageType == typeof (MyProfile))
                {
                    MyFrame.GoBack();
                    Title.Text = "Profile";
                    ProfileListBoxItem.IsSelected = true;
                    var a = (Profile)MyFrame.Content;
                    if (a != null)
                        a.OnNavigateParentReady += OnCreateUser;

                    var b = (Profile)MyFrame.Content;
                    if (b != null)
                        b.OnNavigateLogin += OnLogin;
                }
                else
                {
                    MyFrame.GoBack();

                    if (MyFrame.CurrentSourcePageType == typeof (Home))
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
                    else if (MyFrame.CurrentSourcePageType == typeof (Locations))
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
                    else if (MyFrame.CurrentSourcePageType == typeof (Map))
                    {
                        Title.Text = "Map";
                        MapListBoxItem.IsSelected = true;
                        if (MyFrame.CanGoBack)
                            MyFrame.GoBack();
                    }
                    else if (MyFrame.CurrentSourcePageType == typeof (Profile))
                    {
                        Title.Text = "Profile";
                        ProfileListBoxItem.IsSelected = true;
                        if (MyFrame.CanGoBack)
                            MyFrame.GoBack();

                        var a = (Profile)MyFrame.Content;
                        if (a != null)
                            a.OnNavigateParentReady += OnCreateUser;

                        var b = (Profile)MyFrame.Content;
                        if (b != null)
                            b.OnNavigateLogin += OnLogin;
                    }
                    else if (MyFrame.CurrentSourcePageType == typeof (Contact))
                    {
                        Title.Text = "Contact";
                        ContactListBoxItem.IsSelected = true;
                        if (MyFrame.CanGoBack)
                            MyFrame.GoBack();
                    }
                    else if (MyFrame.CurrentSourcePageType == typeof (CreateUser))
                    {
                        Title.Text = "Create User";
                    }
                }
            }
        }

        public void OnCreateUser(object sender, RoutedEventArgs e)
        {
            if (MySplitView.Content != null)
                ((Frame)MySplitView.Content).Navigate(typeof(CreateUser));
            Title.Text = "Create User";
            BackButton.Visibility = Visibility.Visible;
            Title.Margin = new Thickness(0, 0, 0, 0);

            var a = (CreateUser)MyFrame.Content;
            if (a != null)
                a.OnNavigateParentReady += OnUserCreated;


        }

        public void OnUserCreated(object sender, RoutedEventArgs e)
        {
            if (MySplitView.Content != null)
                ((Frame)MySplitView.Content).Navigate(typeof(Profile));
            Title.Text = "Profile";
            BackButton.Visibility = Visibility.Visible;
            Title.Margin = new Thickness(0, 0, 0, 0);

            var a = (Profile)MyFrame.Content;
            if (a != null)
                a.OnNavigateParentReady += OnCreateUser;

            var b = (Profile)MyFrame.Content;
            if (b != null)
                b.OnNavigateLogin += OnLogin;
        }

        public void OnLogin(object sender, RoutedEventArgs e)
        {
            if (MySplitView.Content != null)
                ((Frame) MySplitView.Content).Navigate(typeof (MyProfile));
            Title.Text = "My Profile";
            BackButton.Visibility = Visibility.Visible;
            Title.Margin = new Thickness(0, 0, 0, 0);
        }

        private void MyAutoSuggestBox_OnQuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            ApartmentManager.GetAllApartments(apartments);
            // we gonna write the code and clikcEvent to navigate the new page called "searches" looks alike "MostPopular"

        }

        private void MyAutoSuggestBox_OnTextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {

            ApartmentManager.GetAllApartments(apartments);
            Suggestions = apartments
                .Where(p => p.ApartmentCity.ToString().ToLower().StartsWith(sender.Text))
                .Select(p => p.ApartmentCity.ToString()).Distinct()
                .ToList();
            MyAutoSuggestBox.ItemsSource = Suggestions;
            
            
        }
    }
}
