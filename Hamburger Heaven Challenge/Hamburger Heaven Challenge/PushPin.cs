using System;
using Windows.Devices.Geolocation;

namespace Hamburger_Heaven_Challenge
{
    
    internal class PushPin
    {

        public Geopoint Geopoint { get; set; }


        public PushPin(double latitude, double longitude)
        {
            Geopoint = new Geopoint(new BasicGeoposition() { Latitude = latitude, Longitude = longitude });
        }
    }
}