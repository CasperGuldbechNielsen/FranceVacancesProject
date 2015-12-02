using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamburger_Heaven_Challenge.Models
{
    
        public class ApartmentManager
        {
            public static void GetAllApartments(ObservableCollection<Apartment> apartments )
            {
                var allApartments = getApartments();
                apartments.Clear();
                allApartments.ForEach(p => apartments.Add(p));
            }

            public static void GetApartmentsByRegionCategory(ObservableCollection<Apartment> apartments,
                RegionCategory apartmentRegionCategory)
            {
                var allApartments = getApartments();
                var filteredApartments = allApartments.Where(p => p.ApartmentRegion == apartmentRegionCategory).ToList();
                apartments.Clear();
                filteredApartments.ForEach(p => apartments.Add(p));
            }

            public static void GetApartmentsByCityCategory(ObservableCollection<Apartment> apartments,
                CityCategory apartmentCityCategory)
            {
                var allApartments = getApartments();
                var filteredApartments = allApartments.Where(p => p.ApartmentCity == apartmentCityCategory).ToList();
                apartments.Clear();
                filteredApartments.ForEach(p => apartments.Add(p));
            }

            public static void GetApartmentsByRoomCategory(ObservableCollection<Apartment> apartments,
                RoomCategory apartmentRoomCategory)
            {
                var allApartments = getApartments();
                var filteredApartments = allApartments.Where(p => p.ApartmentRoomNumber == apartmentRoomCategory).ToList();
                apartments.Clear();
                filteredApartments.ForEach(p => apartments.Add(p));
            }

        //Only works with the ApartmentID so far, it looks like the "StartsWith" only works with strings...

            public static void SearchApartmentsByCity(ObservableCollection<Apartment> apartments, string numberId)
            {
            var allApartments = getApartments();
            var filteredSounds = allApartments.Where(p => p.ApartmentId == numberId).ToList();
            apartments.Clear();
            filteredSounds.ForEach(p => apartments.Add(p));

            }

        
            private static List<Apartment> getApartments()
            {
                var apartments = new List<Apartment>();

                apartments.Add(new Apartment("001", RegionCategory.Alsace, CityCategory.Ajaccio, RoomCategory.One, 1.3, true, 150.50));
                apartments.Add(new Apartment("002", RegionCategory.Alsace, CityCategory.Amiens, RoomCategory.Two, 4.5, true, 200.50));
                apartments.Add(new Apartment("003", RegionCategory.Aquitaine, CityCategory.ClermontFerrand, RoomCategory.Three, 3.8, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("005", RegionCategory.Bourgogne, CityCategory.Orléans, RoomCategory.Two, 4.2, true, 300.50));
                apartments.Add(new Apartment("006", RegionCategory.BasseNormandie, CityCategory.Orléans, RoomCategory.Three, 3.8, true, 140.90));
                apartments.Add(new Apartment("007", RegionCategory.Bretagne, CityCategory.ChâlonsEnChampagne, RoomCategory.Four, 4.5, true, 175.30));
                apartments.Add(new Apartment("008", RegionCategory.Bourgogne, CityCategory.ChâlonsEnChampagne, RoomCategory.Three, 4.9, true, 200.70));
                apartments.Add(new Apartment("009", RegionCategory.CentreValDeLoire, CityCategory.ChâlonsEnChampagne, RoomCategory.Five, 2.7, true, 302.80));
                apartments.Add(new Apartment("010", RegionCategory.CentreValDeLoire, CityCategory.ChâlonsEnChampagne, RoomCategory.Three, 3.9, true, 270.80));
                apartments.Add(new Apartment("011", RegionCategory.ChampagneArdenne, CityCategory.Paris, RoomCategory.Six, 4.2, true, 150.50));
                apartments.Add(new Apartment("012", RegionCategory.ChampagneArdenne, CityCategory.Paris, RoomCategory.Six, 2.7, true, 200.50));
                apartments.Add(new Apartment("013", RegionCategory.Corsica, CityCategory.Montpellier, RoomCategory.Two, 2.7, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("014", RegionCategory.ChampagneArdenne, CityCategory.Montpellier, RoomCategory.Eight, 4.5, true, 300.50));
                apartments.Add(new Apartment("015", RegionCategory.ChampagneArdenne, CityCategory.Montpellier, RoomCategory.One, 4.2, true, 140.90));
                apartments.Add(new Apartment("016", RegionCategory.FrancheComté, CityCategory.Limoges, RoomCategory.One, 4.9, true, 175.30));
                apartments.Add(new Apartment("017", RegionCategory.HauteNormandie, CityCategory.Limoges, RoomCategory.Two, 3.9, true, 200.70));
                apartments.Add(new Apartment("018", RegionCategory.ÎleDeFrance, CityCategory.Limoges, RoomCategory.Three, 4.2, true, 302.80));
                apartments.Add(new Apartment("019", RegionCategory.ÎleDeFrance, CityCategory.Metz, RoomCategory.Four, 4.2, true, 270.80));
                apartments.Add(new Apartment("020", RegionCategory.ÎleDeFrance, CityCategory.Metz, RoomCategory.Five, 3.9, true, 140.90));
                apartments.Add(new Apartment("021", RegionCategory.ÎleDeFrance, CityCategory.Metz, RoomCategory.Six, 4.5, true, 150.50));
                apartments.Add(new Apartment("022", RegionCategory.LanguedocRoussillon, CityCategory.Caen, RoomCategory.Seven, 4.2, true, 200.50));
                apartments.Add(new Apartment("023", RegionCategory.LanguedocRoussillon, CityCategory.Caen, RoomCategory.Eight, 3.8, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("024", RegionCategory.LanguedocRoussillon, CityCategory.Caen, RoomCategory.One, 3.8, true, 300.50));
                apartments.Add(new Apartment("025", RegionCategory.Limousin, CityCategory.Tolouse, RoomCategory.Two, 4.2, true, 140.90));
                apartments.Add(new Apartment("026", RegionCategory.Limousin, CityCategory.Tolouse, RoomCategory.Three, 3.9, true, 175.30));
                apartments.Add(new Apartment("027", RegionCategory.Limousin, CityCategory.Tolouse, RoomCategory.Four, 2.7, true, 200.70));
                apartments.Add(new Apartment("028", RegionCategory.Lorraine, CityCategory.Lille, RoomCategory.Five, 2.7, true, 302.80));
                apartments.Add(new Apartment("029", RegionCategory.Lorraine, CityCategory.Lille, RoomCategory.Six, 4.2, true, 270.80));
                apartments.Add(new Apartment("030", RegionCategory.Lorraine, CityCategory.Lille, RoomCategory.Seven, 4.9, true, 140.90));
                apartments.Add(new Apartment("031", RegionCategory.MidiPyrénées, CityCategory.Nantes, RoomCategory.Eight, 3.8, true, 150.50));
                apartments.Add(new Apartment("032", RegionCategory.MidiPyrénées, CityCategory.Nantes, RoomCategory.One, 4.5, true, 200.50));
                apartments.Add(new Apartment("033", RegionCategory.MidiPyrénées, CityCategory.Nantes, RoomCategory.Two, 4.9, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("034", RegionCategory.NordPasDeCalais, CityCategory.Amiens, RoomCategory.Three, 4.2, true, 300.50));
                apartments.Add(new Apartment("035", RegionCategory.NordPasDeCalais, CityCategory.Amiens, RoomCategory.Four, 2.7, true, 140.90));
                apartments.Add(new Apartment("036", RegionCategory.NordPasDeCalais, CityCategory.Amiens, RoomCategory.Five, 4.9, true, 175.30));
                apartments.Add(new Apartment("037", RegionCategory.PaysDeLaLoire, CityCategory.Poitiers, RoomCategory.Six, 4.5, true, 200.70));
                apartments.Add(new Apartment("038", RegionCategory.PaysDeLaLoire, CityCategory.Poitiers, RoomCategory.Seven, 2.7, true, 270.80));
                apartments.Add(new Apartment("039", RegionCategory.PaysDeLaLoire, CityCategory.Poitiers, RoomCategory.Eight, 3.9, true, 140.90));
                apartments.Add(new Apartment("040", RegionCategory.Picardie, CityCategory.Marseille, RoomCategory.One, 4.9, true, 140.90));
                apartments.Add(new Apartment("041", RegionCategory.Picardie, CityCategory.Marseille, RoomCategory.Two, 2.7, true, 150.50));
                apartments.Add(new Apartment("042", RegionCategory.PoitouCharentes, CityCategory.Marseille, RoomCategory.Three, 3.8, true, 200.50));
                apartments.Add(new Apartment("043", RegionCategory.PoitouCharentes, CityCategory.Lyon, RoomCategory.Four, 3.8, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("044", RegionCategory.PoitouCharentes, CityCategory.Lyon, RoomCategory.Five, 3.8, true, 300.50));
                apartments.Add(new Apartment("045", RegionCategory.ProvenceAlpesCôteDAzur, CityCategory.Lyon, RoomCategory.Six, 4.5, true, 140.90));
                apartments.Add(new Apartment("046", RegionCategory.ProvenceAlpesCôteDAzur, CityCategory.Rouen, RoomCategory.Seven, 4.2, true, 175.30));
                apartments.Add(new Apartment("046", RegionCategory.ProvenceAlpesCôteDAzur, CityCategory.Rouen, RoomCategory.Eight, 3.8, true, 200.70));
                apartments.Add(new Apartment("047", RegionCategory.RhôneAlpes, CityCategory.Rouen, RoomCategory.One, 4.2, true, 302.80));
                apartments.Add(new Apartment("048", RegionCategory.RhôneAlpes, CityCategory.Ajaccio, RoomCategory.Two, 3.9, true, 270.80));
                apartments.Add(new Apartment("049", RegionCategory.RhôneAlpes, CityCategory.Ajaccio, RoomCategory.Three, 3.9, true, 140.90));
                apartments.Add(new Apartment("050", RegionCategory.Aquitaine, CityCategory.Ajaccio, RoomCategory.Four, 2.7, true, 140.90));
                apartments.Add(new Apartment("051", RegionCategory.Aquitaine, CityCategory.Strasbourg, RoomCategory.Five, 4.5, true, 150.50));
                apartments.Add(new Apartment("052", RegionCategory.Auvergne, CityCategory.Strasbourg, RoomCategory.Six, 2.7, true, 200.50));
                apartments.Add(new Apartment("053", RegionCategory.Auvergne, CityCategory.Strasbourg, RoomCategory.Seven, 4.7, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("054", RegionCategory.Auvergne, CityCategory.Bordeaux, RoomCategory.Eight, 3.8, true, 300.50));
                apartments.Add(new Apartment("056", RegionCategory.CentreValDeLoire, CityCategory.Bordeaux, RoomCategory.One, 4.2, true, 140.90));
                apartments.Add(new Apartment("057", RegionCategory.CentreValDeLoire, CityCategory.Bordeaux, RoomCategory.Two, 3.8, true, 175.30));
                apartments.Add(new Apartment("058", RegionCategory.CentreValDeLoire, CityCategory.ClermontFerrand, RoomCategory.Three, 4.5, true, 200.70));
                apartments.Add(new Apartment("059", RegionCategory.LanguedocRoussillon, CityCategory.ClermontFerrand, RoomCategory.Four, 4.9, true, 302.80));
                apartments.Add(new Apartment("060", RegionCategory.LanguedocRoussillon, CityCategory.ClermontFerrand, RoomCategory.Five, 4.7, true, 270.80));
                apartments.Add(new Apartment("061", RegionCategory.MidiPyrénées, CityCategory.Rennes, RoomCategory.Six, 2.7, true, 150.50));
                apartments.Add(new Apartment("062", RegionCategory.MidiPyrénées, CityCategory.Rennes, RoomCategory.Seven, 4.2, true, 200.50));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("063", RegionCategory.MidiPyrénées, CityCategory.Rennes, RoomCategory.Eight, 4.5, true, 300.50));
                apartments.Add(new Apartment("064", RegionCategory.PoitouCharentes, CityCategory.Dijon, RoomCategory.One, 4.7, true, 140.90));
                apartments.Add(new Apartment("065", RegionCategory.PoitouCharentes, CityCategory.Dijon, RoomCategory.Two, 3.8, true, 175.30));
                apartments.Add(new Apartment("066", RegionCategory.PoitouCharentes, CityCategory.Dijon, RoomCategory.Three, 3.8, true, 200.70));
                apartments.Add(new Apartment("067", RegionCategory.Alsace, CityCategory.Orléans, RoomCategory.Four, 2.7, true, 302.80));
                apartments.Add(new Apartment("068", RegionCategory.Alsace, CityCategory.Orléans, RoomCategory.Five, 4.9, true, 270.80));
                apartments.Add(new Apartment("069", RegionCategory.HauteNormandie, CityCategory.Orléans, RoomCategory.Six, 3.8, true, 140.90));
                apartments.Add(new Apartment("070", RegionCategory.HauteNormandie, CityCategory.ChâlonsEnChampagne, RoomCategory.Seven, 4.7, true, 270.80));
                apartments.Add(new Apartment("071", RegionCategory.Bretagne, CityCategory.ChâlonsEnChampagne, RoomCategory.Eight, 4.5, true, 150.50));
                apartments.Add(new Apartment("072", RegionCategory.Bretagne, CityCategory.ChâlonsEnChampagne, RoomCategory.One, 3.8, true, 200.50));
                apartments.Add(new Apartment("073", RegionCategory.ÎleDeFrance, CityCategory.Paris, RoomCategory.Two, 2.7, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("074", RegionCategory.ÎleDeFrance, CityCategory.Paris, RoomCategory.Three, 4.2, true, 300.50));
                apartments.Add(new Apartment("075", RegionCategory.PaysDeLaLoire, CityCategory.Paris, RoomCategory.Four, 2.7, true, 140.90));
                apartments.Add(new Apartment("076", RegionCategory.PaysDeLaLoire, CityCategory.Montpellier, RoomCategory.Five, 3.8, true, 175.30));
                apartments.Add(new Apartment("077", RegionCategory.ProvenceAlpesCôteDAzur, CityCategory.Montpellier, RoomCategory.Six, 2.7, true, 200.70));
                apartments.Add(new Apartment("078", RegionCategory.ProvenceAlpesCôteDAzur, CityCategory.Montpellier, RoomCategory.Seven, 4.5, true, 302.80));
                apartments.Add(new Apartment("079", RegionCategory.ProvenceAlpesCôteDAzur, CityCategory.Limoges, RoomCategory.Eight, 4.9, true, 270.80));
                apartments.Add(new Apartment("080", RegionCategory.LanguedocRoussillon, CityCategory.Limoges, RoomCategory.One, 4.7, true, 140.90));
                apartments.Add(new Apartment("081", RegionCategory.LanguedocRoussillon, CityCategory.Metz, RoomCategory.Two, 4.2, true, 150.50));
                apartments.Add(new Apartment("082", RegionCategory.Limousin, CityCategory.Metz, RoomCategory.Three, 4.5, true, 200.50));
                apartments.Add(new Apartment("083", RegionCategory.Limousin, CityCategory.Caen, RoomCategory.Four, 4.7, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("084", RegionCategory.Lorraine, CityCategory.Caen, RoomCategory.Five, 4.7, true, 300.50));
                apartments.Add(new Apartment("085", RegionCategory.Lorraine, CityCategory.Tolouse, RoomCategory.Six, 2.7, true, 140.90));
                apartments.Add(new Apartment("086", RegionCategory.Lorraine, CityCategory.Tolouse, RoomCategory.Seven, 4.9, true, 175.30));
                apartments.Add(new Apartment("087", RegionCategory.PoitouCharentes, CityCategory.Lille, RoomCategory.Eight, 4.2, true, 200.70));
                apartments.Add(new Apartment("088", RegionCategory.PoitouCharentes, CityCategory.Lille, RoomCategory.One, 4.5, true, 302.80));
                apartments.Add(new Apartment("089", RegionCategory.PoitouCharentes, CityCategory.Nantes, RoomCategory.Two, 4.9, true, 270.80));
                apartments.Add(new Apartment("090", RegionCategory.RhôneAlpes, CityCategory.Nantes, RoomCategory.Three, 3.8, true, 140.90));
                apartments.Add(new Apartment("091", RegionCategory.RhôneAlpes, CityCategory.Amiens, RoomCategory.Four, 4.7, true, 150.50));
                apartments.Add(new Apartment("092", RegionCategory.RhôneAlpes, CityCategory.Amiens, RoomCategory.Five, 2.7, true, 200.50));
                apartments.Add(new Apartment("093", RegionCategory.Auvergne, CityCategory.Poitiers, RoomCategory.Six, 4.7, true, 120.20));
                apartments.Add(new Apartment("004", RegionCategory.Auvergne, CityCategory.Dijon, RoomCategory.One, 3.9, true, 260.80));
                apartments.Add(new Apartment("094", RegionCategory.Auvergne, CityCategory.Poitiers, RoomCategory.Seven, 3.8, true, 300.50));
                apartments.Add(new Apartment("095", RegionCategory.Auvergne, CityCategory.Marseille, RoomCategory.Eight, 4.2, true, 140.90));
                apartments.Add(new Apartment("096", RegionCategory.Auvergne, CityCategory.Marseille, RoomCategory.One, 4.5, true, 175.30));
                apartments.Add(new Apartment("097", RegionCategory.Auvergne, CityCategory.Lyon, RoomCategory.Two, 3.8, true, 200.70));
                apartments.Add(new Apartment("098", RegionCategory.LanguedocRoussillon, CityCategory.Lyon, RoomCategory.Three, 4.7, true, 302.80));
                apartments.Add(new Apartment("099", RegionCategory.LanguedocRoussillon, CityCategory.Rouen, RoomCategory.Four, 2.7, true, 270.80));
                apartments.Add(new Apartment("100", RegionCategory.PoitouCharentes, CityCategory.Rouen, RoomCategory.Five, 3.8, true, 140.90));
                
                return apartments;

            }
        
    }
}
