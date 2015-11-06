using System.Collections.ObjectModel;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Map : Page
    {
        PushPin pushPin = new PushPin();

        public Map()
        {
            this.InitializeComponent();

            AddPushPins();
            AddIcon();

            MyMap.Center = new Geopoint(new BasicGeoposition() {Latitude = 46.8442643, Longitude = 2.5992004 });
            MyMap.ZoomLevel = 6;

        }

        public void AddPushPins()
        {
            pushPin.AddPushPin(46.8442643, 2.5992004);
            pushPin.AddPushPin(48.873121, 2.374912);
            pushPin.AddPushPin(44.834876, -0.588417);


        }

        public void AddIcon()
        {

            for (int i = 0; i < pushPin.Items().Count; i++)
            {
                MapIcon myIcon = new MapIcon();
                myIcon.NormalizedAnchorPoint = new Point(0.5, 1.0);
                myIcon.Title = "Apartment here";
                MyMap.MapElements.Add(myIcon);
                myIcon.Location = pushPin.MyGeopoint(i);
            }
        }
    }
}
