using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace Hamburger_Heaven_Challenge.Models
{
    public class Apartment
    {
        private string _apartmentId;
        private RegionCategory _apartmentRegion;
        private CityCategory _apartmentCity;
        private RoomCategory _apartmentRoomNumber;
        private string _apartmentCoverImage;
        private string _apartmentInsideImage;
        private double _apartmentRating;
        private bool _isApartmentAvailable;
        private double _apartmentPriceByNight;
        private int _numberOfNightSpent;
        private double _apartmentPriceTotal;

        public string ApartmentId
        {
            get { return _apartmentId; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(ApartmentId));
                }
                _apartmentId = value;
            }
        }

        public RegionCategory ApartmentRegion
        {
            get { return _apartmentRegion; }
            set {_apartmentRegion = value; }
        }

        public CityCategory ApartmentCity
        {
            get { return _apartmentCity; }
            set { _apartmentCity = value;}
        }

        public RoomCategory ApartmentRoomNumber
        {
            get { return _apartmentRoomNumber; }
            set { _apartmentRoomNumber = value; }
        }

        public string ApartmentCoverImage
        {
            get { return _apartmentCoverImage; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(ApartmentCoverImage));
                }
                _apartmentCoverImage = value;
            }
        }

        public string ApartmentInsideImage
        {
            get { return _apartmentInsideImage; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(ApartmentInsideImage));
                }
                _apartmentInsideImage = value;
            }
        }

        public double ApartmentRating
        {
            get { return _apartmentRating; }
            set
            {
                if (value < 0 || 5 > value)
                {
                    throw new ArgumentOutOfRangeException(nameof(ApartmentRating));
                }
                _apartmentRating = value;
            }
        }

        public bool IsApartmentAvailable
        {
            get { return _isApartmentAvailable; }
            set{ _isApartmentAvailable = value; }
        }

        public double ApartmentPriceByNight
        {
            get { return _apartmentPriceByNight; }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentOutOfRangeException(nameof(ApartmentPriceByNight));
                }
                _apartmentPriceByNight = value;
            }
        }

        public int NumberOfNightSpent
        {
            get { return _numberOfNightSpent; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException(nameof(NumberOfNightSpent));
                }
                _numberOfNightSpent = value;
            }
        }

        public double ApartmentPriceTotal
        {
            get { return _apartmentPriceTotal; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException(nameof(ApartmentPriceTotal));
                }
                _apartmentPriceTotal = value;
            }
        }

        public Apartment()
        {
            
        }

        public Apartment(string apartmentId, RegionCategory apartmentRegion, CityCategory apartmentCity,
            RoomCategory apartmentRoomNumber, double apartmentRating, bool isApartmentAvailable, double apartmentPriceByNight)
        {
            ApartmentId = apartmentId;
            ApartmentRegion = apartmentRegion;
            ApartmentCity = apartmentCity;
            ApartmentRoomNumber = apartmentRoomNumber;
            ApartmentCoverImage = String.Format("Assets/ApartmentImages/CoverImages/{0}/FrontView.jpg", apartmentId);
            ApartmentInsideImage = String.Format("Assets/ApartmentImages/InsideImages/{0}/InsideView.jpg", apartmentId);
            ApartmentRating = apartmentRating;
            IsApartmentAvailable = isApartmentAvailable;
            ApartmentPriceByNight = apartmentPriceByNight;

        }

        public double GetBookingPriceTotal(int numberOfNightSpent)
        {
            NumberOfNightSpent = numberOfNightSpent;
            ApartmentPriceTotal = ApartmentPriceByNight*numberOfNightSpent;
            return ApartmentPriceTotal;
        }

        public string GetCoverImage()
        {
            return ApartmentCoverImage;
        }

        public string GetInsideImage()
        {
            return ApartmentInsideImage;
        }

    }

    
    public enum RegionCategory
    {
        Alsace,
        Aquitaine,
        Auvergne,
        BasseNormandie,
        Bretagne,
        Bourgogne,
        CentreValDeLoire,
        ChampagneArdenne,
        Corsica,
        FrancheComté,
        HauteNormandie,
        ÎleDeFrance,
        LanguedocRoussillon,
        Limousin,
        Lorraine,
        MidiPyrénées,
        NordPasDeCalais,
        PaysDeLaLoire,
        Picardie,
        PoitouCharentes,
        ProvenceAlpesCôteDAzur,
        RhôneAlpes,
        
    }

    public enum CityCategory
    {
        Strasbourg,
        Bordeaux,
        ClermontFerrand,
        Rennes,
        Dijon,
        Orléans,
        ChâlonsEnChampagne,
        Paris,
        Montpellier,
        Limoges,
        Metz,
        Caen,
        Tolouse,
        Lille,
        Nantes,
        Amiens,
        Poitiers,
        Marseille,
        Lyon,
        Rouen,
        Ajaccio,
    }

    public enum RoomCategory
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
    }

    
  }
 

