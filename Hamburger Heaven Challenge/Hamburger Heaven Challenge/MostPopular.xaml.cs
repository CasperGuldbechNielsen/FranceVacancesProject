﻿
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Hamburger_Heaven_Challenge.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Hamburger_Heaven_Challenge
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MostPopular : Page
    {

        private ObservableCollection<Apartment> Apartments;

        private List<ApartmentRegionSelector> ApartmentRegionSelector;
        private List<ApartmentCitySelector> ApartmentCitySelector;
        private List<ApartmentRoomSelector> ApartmentRoomSelector; 

        
        public MostPopular()
        {
          this.InitializeComponent();
          Apartments = new ObservableCollection<Apartment>();
          ApartmentManager.GetAllApartments(Apartments);

            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Alsace});
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Aquitaine });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Auvergne });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.BasseNormandie });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Bretagne });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Bourgogne });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.CentreValDeLoire });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.ChampagneArdenne });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Corsica });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.FrancheComté });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.HauteNormandie });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.ÎleDeFrance });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.LanguedocRoussillon });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Limousin });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Lorraine });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.MidiPyrénées });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.NordPasDeCalais });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.PaysDeLaLoire });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.Picardie });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.PoitouCharentes });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.ProvenceAlpesCôteDAzur });
            ApartmentRegionSelector.Add(new ApartmentRegionSelector { ApartmentRegion = RegionCategory.RhôneAlpes });


            ApartmentCitySelector.Add(new ApartmentCitySelector{ ApartmentCity = CityCategory.Ajaccio });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Strasbourg });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Bordeaux });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.ClermontFerrand });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Rennes });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Dijon });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Orléans });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.ChâlonsEnChampagne });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Paris });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Montpellier });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Limoges });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Metz });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Caen });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Tolouse });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Lille });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Nantes });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Amiens });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Poitiers });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Marseille });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Lyon });
            ApartmentCitySelector.Add(new ApartmentCitySelector { ApartmentCity = CityCategory.Rouen });
            
            ApartmentRoomSelector.Add(new ApartmentRoomSelector { ApartmentRoomNumber = RoomCategory.One});
            ApartmentRoomSelector.Add(new ApartmentRoomSelector { ApartmentRoomNumber = RoomCategory.Two });
            ApartmentRoomSelector.Add(new ApartmentRoomSelector { ApartmentRoomNumber = RoomCategory.Three });
            ApartmentRoomSelector.Add(new ApartmentRoomSelector { ApartmentRoomNumber = RoomCategory.Four });
            ApartmentRoomSelector.Add(new ApartmentRoomSelector { ApartmentRoomNumber = RoomCategory.Five });
            ApartmentRoomSelector.Add(new ApartmentRoomSelector { ApartmentRoomNumber = RoomCategory.Six });
            ApartmentRoomSelector.Add(new ApartmentRoomSelector { ApartmentRoomNumber = RoomCategory.Seven });
            ApartmentRoomSelector.Add(new ApartmentRoomSelector { ApartmentRoomNumber = RoomCategory.Eight });



        }



        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var apartments = (Apartment)e.ClickedItem;
            ApartmentResultTextBlock.Text = "You have selected apartment # " + apartments.ApartmentId;
        }


      

        
    }
}

