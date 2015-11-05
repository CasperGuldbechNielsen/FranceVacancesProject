using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Map : Page
    {

        public Map()
        {
            this.InitializeComponent();
            MyMap.Center = new Geopoint(new BasicGeoposition() {Latitude = 46.8442643, Longitude = 2.5992004 });
        }

    }
}
