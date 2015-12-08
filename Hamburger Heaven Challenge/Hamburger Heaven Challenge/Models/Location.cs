using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{

    // TODO: copy images to assests folder, change list with image string



    public class Location
    {
        public string CityImage { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        
    }

    public class LocationManager
    {
        public static List<Location> GetLocations()
        {
            var locations = new List<Location>();

            locations.Add(new Location { CityImage ="Assets/LocationPictures/Paris.jpg", City = "Paris", Description = "Paris, the City of Light, evokes romantic emotions in anyone who has ever visited. " +
                                                                       "This centuries-old city is the most visited city in the world, and for good reason. " +
                                                                       "There is plenty to do in Paris to satisfy travelers of all tastes." });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Strasbourg.jpg", City = "Strasbourg", Description = "Controlled by the British for 300 years, Bordeaux is one of the most un-French" +
                                                                            " cities in France (a good or bad thing, depending on your tastes). What was once a sleepy city " +
                                                                            "(literally nicknamed Sleeping Beauty in French) is now a thriving tourist destination " +
                                                                            "and mecca for wine enthusiasts. The city's boundless energy is supplemented by the spirited " +
                                                                            "university population. Unless you've been wine-tasting all day... then you'll probably sleep quite well. " });
            
            locations.Add(new Location{ CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/.jpg", City = "", Description = "" });


            return locations;
        }

    }
}
