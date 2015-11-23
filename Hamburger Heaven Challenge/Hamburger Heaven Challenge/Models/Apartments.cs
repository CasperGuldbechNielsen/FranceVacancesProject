using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{
    public class Apartments
    {
        private int _roomNumbers;
        public int ApartmentID { get; set; }
        public string ApartmentRegion { get; set; }
        public string ApartmentCity { set; get; }

        public int RoomNumbers
        {
            get { return _roomNumbers; }
            set
            {
                if (value <= 0) 
                    throw new ArgumentOutOfRangeException(nameof(RoomNumbers));
                _roomNumbers = value;
            }
        }

        public string ApartmentCoverImage { get; set; }
        public string ApartmentRating { get; set; }

    }

    public class ApartmentManager
    {
        public static void GetAllApartments(ObservableCollection<Apartments> apartments)
        {
            var allApartments = GetApartments();
            apartments.Clear();
            allApartments.ForEach(p => apartments.Add(p));
        }
        public static List<Apartments> GetApartments()
        {
            var apartments = new List<Apartments>();

            apartments.Add(new Apartments { ApartmentID = 1, ApartmentRegion = "Capital", ApartmentCity = "Paris", RoomNumbers = 2, ApartmentCoverImage = "Assets/ApartmentImages/house1.jpg", ApartmentRating = "4.5" });
            apartments.Add(new Apartments { ApartmentID = 2, ApartmentRegion = "Burgundy", ApartmentCity = "Bordeaux", RoomNumbers = 1, ApartmentCoverImage = "Assets/ApartmentImages/house2.jpg", ApartmentRating = "5" });
            apartments.Add(new Apartments { ApartmentID = 3, ApartmentRegion = "Champagne-Ardenne", ApartmentCity = "Tolouse", RoomNumbers = 3, ApartmentCoverImage = "Assets/ApartmentImages/house3.jpg", ApartmentRating = "3" });
            apartments.Add(new Apartments { ApartmentID = 4, ApartmentRegion = "Nord-Pas-de-Calais", ApartmentCity = "Montpellier", RoomNumbers = 4, ApartmentCoverImage = "Assets/ApartmentImages/house4.jpg", ApartmentRating = "4.2" });
            apartments.Add(new Apartments { ApartmentID = 5, ApartmentRegion = "Auvergne", ApartmentCity = "Marseille", RoomNumbers = 3, ApartmentCoverImage = "Assets/ApartmentImages/house5.jpg", ApartmentRating = "4.8" });
            apartments.Add(new Apartments { ApartmentID = 6, ApartmentRegion = "Rhône-Alpes", ApartmentCity = "Normandes", RoomNumbers = 2, ApartmentCoverImage = "Assets/ApartmentImages/house1.jpg", ApartmentRating = "4.5" });
            apartments.Add(new Apartments { ApartmentID = 7, ApartmentRegion = "Lorraine", ApartmentCity = "Ardenneux", RoomNumbers = 2, ApartmentCoverImage = "Assets/ApartmentImages/house2.jpg", ApartmentRating = "4.4" });
            apartments.Add(new Apartments { ApartmentID = 8, ApartmentRegion = "Midi-Pyrénées", ApartmentCity = "Pirene-de-Champs", RoomNumbers = 4, ApartmentCoverImage = "Assets/ApartmentImages/house3.jpg", ApartmentRating = "3.5" });
            apartments.Add(new Apartments { ApartmentID = 9, ApartmentRegion = "Capital", ApartmentCity = "Pris", RoomNumbers = 3, ApartmentCoverImage = "Assets/ApartmentImages/house4.jpg", ApartmentRating = "4.5" });
            apartments.Add(new Apartments { ApartmentID = 10, ApartmentRegion = "Burgundy", ApartmentCity = "Deux-ex-Viu", RoomNumbers = 3, ApartmentCoverImage = "Assets/ApartmentImages/house5.jpg", ApartmentRating = "4.7" });
            apartments.Add(new Apartments { ApartmentID = 11, ApartmentRegion = "Champagne-Ardenne", ApartmentCity = "Tolouse", RoomNumbers = 1, ApartmentCoverImage = "Assets/ApartmentImages/house1.jpg", ApartmentRating = "2.5" });
            apartments.Add(new Apartments { ApartmentID = 12, ApartmentRegion = "Nord-Pas-de-Calais", ApartmentCity = "Montpellier", RoomNumbers = 3, ApartmentCoverImage = "Assets/ApartmentImages/house2.jpg", ApartmentRating = "4.5" });
            apartments.Add(new Apartments { ApartmentID = 13, ApartmentRegion = "Auvergne", ApartmentCity = "Fazios", RoomNumbers = 2, ApartmentCoverImage = "Assets/ApartmentImages/house3.jpg", ApartmentRating = "5" });
            apartments.Add(new Apartments { ApartmentID = 14, ApartmentRegion = "Rhône-Alpes", ApartmentCity = "Venice", RoomNumbers = 4, ApartmentCoverImage = "Assets/ApartmentImages/house4.jpg", ApartmentRating = "2.5" });
            apartments.Add(new Apartments { ApartmentID = 15, ApartmentRegion = "Midi-Pyrénées", ApartmentCity = "Devoux", RoomNumbers = 1, ApartmentCoverImage = "Assets/ApartmentImages/house5.jpg", ApartmentRating = "not yet rated" });


            return apartments;
        }
    }
}

