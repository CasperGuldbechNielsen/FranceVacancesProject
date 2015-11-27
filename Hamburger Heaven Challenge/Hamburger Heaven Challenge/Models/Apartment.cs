using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{
    public class Apartment
    {
     
        public int ApartmentId { get; set; }
        public RegionCategory ApartmentRegion { get; set; }
        public CityCategory ApartmentCity { get; set; }
        public RoomCategory ApartmentRoomNumber { get; set; }
        public string ApartmentCoverImage { get; set; }
        public string ApartmentInsideImage { get; set; }
        public double ApartmentRating { get; set; }
        public bool IsApartmentAvailable { get; set; }

        public Apartment(int _apartmentId, RegionCategory _apartmentRegion, CityCategory _apartmentCity,
            RoomCategory _apartmentRoomNumber, double _apartmentRating, bool _isApartmentAvailable)
        {
            ApartmentId = _apartmentId;
            ApartmentRegion = _apartmentRegion;
            ApartmentCity = _apartmentCity;
            ApartmentRoomNumber = _apartmentRoomNumber;
            ApartmentCoverImage = String.Format("Assets/ApartmentImages/CoverImages/{0}/FrontView.jpg",  _apartmentId);
            ApartmentInsideImage = String.Format("Assets/ApartmentImages/InsideImages/{0}/InsideView.jpg",  _apartmentId);
            ApartmentRating = _apartmentRating;
            IsApartmentAvailable = _isApartmentAvailable;

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
 

