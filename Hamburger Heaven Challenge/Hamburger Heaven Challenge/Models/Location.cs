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
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Strasbourg.jpg", City = "Strasbourg", Description = "You view great wine as the essence of a good vacation. Your travel companion, however, is a beer aficionado. Will it be Paris or Munich? Stop arguing and go to Strasbourg, where you can have the best of French and German cuisine, including the booze. The entire central island is a World Heritage Site. Don’t miss the 12th-century cathedral or the storybook la Petite France neighborhood. " });
            
            locations.Add(new Location{ CityImage = "Assets/LocationPictures/Bordeaux.jpg", City = "Bordeaux", Description = "Controlled by the British for 300 years, Bordeaux is one of the most un-French " +
                                                                                                                             "cities in France (a good or bad thing, depending on your tastes). What was once a " +
                                                                                                                             "sleepy city (literally nicknamed Sleeping Beauty in French) is now a thriving tourist" +
                                                                                                                             " destination and mecca for wine enthusiasts. The city's boundless energy is supplemented" +
                                                                                                                             " by the spirited university population. Unless you've been wine-tasting all day... then you'll" +
                                                                                                                             " probably sleep quite well. " });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/ClermontFerrand.jpg", City = "ClermontFerrand", Description = "Clermont-Ferrand was the home of mathematician and philosopher Blaise Pascal who tested Evangelista Torricelli's hypothesis concerning the influence of gas pressure on liquid equilibrium. This is the experiment where a vacuum is created in a mercury tube: Pascal's experiment had his brother-in-law carry a barometer to the top of the Puy-de-Dôme. The Université Blaise-Pascal (or Clermont-Ferrand II) is located primarily in the city and is named after him." });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Rennes.jpg", City = "Rennes", Description = "The historic centre is located on the former plan of the ramparts. There is a difference between the northern city centre and the southern city centre due to the 1720 fire, which destroyed most of the timber framed houses in the northern part of the city. The rebuilding was done in stone, on a grid plan. The southern part, the poorest at this time, was not rebuilt. Due to the presence of the parlement de Bretagne, many hôtels particuliers were built in the northern part, the richest in the 18th century. Most of the monuments historiques can be found there. Colourful traditional half - timbered houses are situated primarily along the roads of Saint - Sauveur, Saint - Georges, de Saint - Malo, Saint - Guillaume" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Dijon.jpg", City = "Dijon", Description = "As the ancient capital of the Burgundy province, Dijon is an architecturally rich city offering far more than mustard. In its restored medieval core, you'll discover one of France's oldest museums, the MusÂe des Beaux-Arts, as well as the elegant Palace of the Dukes and the opulent 1614 mansion HÂtel de Vogue. Take a quiet walk through the lime- and chestnut-lined paths of Cours du Parc, a green space dating to 1671, and don't forget to pair the region's rich history with its gastronomic delights. " });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Orléans.jpg", City = "Orléans", Description = "Orléans is a city on the banks of the Loire River in north-central France, and is capital of the Centre-Val de Loire region. Joan of Arc famously saved the city from English siege in 1429, an event celebrated with an annual festival. A re-creation of the house where she stayed during the battle features multimedia exhibits on her life." });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/ChâlonsEnChampagne.jpg", City = "ChâlonsEnChampagne", Description = "Châlons-en-Champagne is a city in France. It is the capital of both the department of Marne and the region of Champagne-Ardenne, despite being only a quarter the size of the city of Reims" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Montpellier.jpg", City = "Montpellier", Description = "Getting sick on vacation is a major drag, but if you have to be under the weather, Montpellier is an ideal place to do it. People have studied medicine here for centuries—the Moors established medical schools in the 9th century, and the Université Montpellier’s school of medicine was founded in 1220. Once the local docs give you a clean bill of health, explore the cathedral, mansions and opera house. " });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Limoges.jpg", City = "Limoges", Description = "Limoges is a city and commune, the capital of the Haute-Vienne department and the administrative capital of the Limousin région in west-central France." });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Metz.jpg", City = "Metz", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Caen.jpg", City = "Caen", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Tolouse.jpg", City = "Tolouse", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Lille.jpg", City = "Lille", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Nantes.jpg", City = "Nantes", Description = "" });
           locations.Add(new Location { CityImage = "Assets/LocationPictures/Amiens.jpg", City = "Amiens", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Poitiers.jpg", City = "Poitiers", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Marseille.jpg", City = "Marseille", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Lyon.jpg", City = "Lyon", Description = "" });
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Rouen.jpg", City = "Rouen", Description = "" });


            return locations;
        }

    }
}
