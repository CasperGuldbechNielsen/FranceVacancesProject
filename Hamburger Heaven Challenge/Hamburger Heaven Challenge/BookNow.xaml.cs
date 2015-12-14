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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Hamburger_Heaven_Challenge.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BookNow : Page
    {

        private List<Apartment> apartments = new List<Apartment>();

        private List<Apartment> selectedApartment = new List<Apartment>();

        private string _apartmentId;
        private int _apartmentIdInt;

        public BookNow()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //this.DataContext = e.Parameter;
            _apartmentId = (string)e.Parameter;
            
            CoverImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/ApartmentImages/CoverImages/" + _apartmentId + "/FrontView.jpg" , UriKind.Absolute));
            InsideImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/ApartmentImages/InsideImages/" + _apartmentId + "/InsideView.jpg", UriKind.Absolute));

            ApartmentManager myManager = new ApartmentManager();

            apartments = myManager.GetAllApartmentsList();

            _apartmentIdInt = Int32.Parse(_apartmentId);

            selectedApartment.Add(apartments[_apartmentIdInt]);

        }
    }
}
