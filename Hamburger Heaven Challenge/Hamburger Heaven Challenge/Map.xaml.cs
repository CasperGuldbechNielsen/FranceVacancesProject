using System.Collections.ObjectModel;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Map : Page
    {
        private ObservableCollection<PushPin> items;

        public Map()
        {
            this.InitializeComponent();
            MyMap.Center = new Geopoint(new BasicGeoposition() {Latitude = 46.8442643, Longitude = 2.5992004 });
            MyMap.ZoomLevel = 6;

            MapItems.ItemsSource = items;

            items = new ObservableCollection<PushPin>();
            items.Add(new PushPin(48.871905, 2.343217));
        }
    }
}
