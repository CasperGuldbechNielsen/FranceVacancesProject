using System;
using System.Collections.ObjectModel;
using Windows.Devices.Geolocation;

namespace Hamburger_Heaven_Challenge
{
    

    internal class PushPin
    {

        private ObservableCollection<Geopoint> items;

        public PushPin()
        {
            items = new ObservableCollection<Geopoint>();
        }

        public void AddPushPin(double latitude, double longitude)
        {
            items.Add(new Geopoint(new BasicGeoposition() { Latitude = latitude, Longitude = longitude }));
        }

        public Geopoint MyGeopoint(int i)
        {
            return items[i];
        }

        public ObservableCollection<Geopoint> Items()
        {
            return items;
        } 
    }
}