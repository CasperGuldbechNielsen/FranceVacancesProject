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

            locations.Add(new Location { CityImage ="Assets/LocationPictures/Paris.jpg", City = "Paris",
                                         Description = "Paris, the City of Light, evokes romantic emotions in anyone who has ever visited. " +
                                                        "This centuries-old city is the most visited city in the world, and for good reason. " +
                                                        "There is plenty to do in Paris to satisfy travelers of all tastes." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Strasbourg.jpg", City = "Strasbourg",
                                         Description = "You view great wine as the essence of a good vacation. Your travel companion, however, is a beer " +
                                                       "aficionado. Will it be Paris or Munich? Stop arguing and go to Strasbourg, " +
                                                        "where you can have the best of French and German cuisine, including the booze. " +
                                                       "The entire central island is a World Heritage Site. Don’t miss the 12th-century cathedral" +
                                                       " or the storybook la Petite France neighborhood. " });
            
            locations.Add(new Location{ CityImage = "Assets/LocationPictures/Bordeaux.jpg", City = "Bordeaux",
                                        Description = "Controlled by the British for 300 years, Bordeaux is one of the most un-French " +"cities in France " +
                                                        "(a good or bad thing, depending on your tastes). What was once a " +
                                                        "sleepy city (literally nicknamed Sleeping Beauty in French) is now a thriving tourist" +
                                                        " destination and mecca for wine enthusiasts. The city's boundless energy is supplemented" +
                                                        " by the spirited university population. Unless you've been wine-tasting all day... then you'll" +
                                                        " probably sleep quite well. " });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/ClermontFerrand.jpg", City = "ClermontFerrand",
                                        Description = "Clermont-Ferrand was the home of mathematician and philosopher Blaise Pascal who tested Evangelista " +
                                                        "Torricelli's hypothesis concerning the influence of gas pressure on liquid equilibrium. " +
                                                        "This is the experiment where a vacuum is created in a mercury tube: Pascal's experiment" +
                                                        " had his brother-in-law carry a barometer to the top of the Puy-de-Dôme. The Université " +
                                                        "Blaise-Pascal (or Clermont-Ferrand II) is located primarily in the city and is named after him. " +
                                                        "The city of Clermont-Ferrand has a lively temperament, as it is the capital of short films, rock music, and rugby. " +
                                                        "The exuberant French city has an exceptional location surrounded by enormous volcanoes. " +
                                                        "The town is just a short distance from Puy de Dome, which is a " +
                                                        "large lava dome that shades the other volcanoes that compose the Puys range. What makes this famous " +
                                                        "city unique among others are the volcanic rocks that are " +
                                                        "used to construct impressive monuments. This is the reason why visitors keep on visiting the city. " +
                                                        "Adding up, the town is the Auvergne’s capital." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Rennes.jpg", City = "Rennes",
                                         Description = "The historic centre is located on the former plan of the ramparts. There is a difference between " +
                                                       "the northern city centre and the southern city centre due to the 1720 fire, " +
                                                        "which destroyed most of the timber framed houses in the northern part of the city. The rebuilding " +
                                                       "was done in stone, on a grid plan. The southern part, the poorest at this time," +
                                                        " was not rebuilt. Due to the presence of the parlement de Bretagne, many hôtels particuliers were" +
                                                       " built in the northern part, the richest in the 18th century. Most of the monuments " +
                                                        "historiques can be found there. Colourful traditional half - timbered houses are situated primarily " +
                                                       "along the roads of Saint - Sauveur, Saint - Georges, de Saint - Malo, Saint - Guillaume" });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Dijon.jpg", City = "Dijon",
                                         Description = "As the ancient capital of the Burgundy province, Dijon is an architecturally rich city offering far " +
                                                       "more than mustard. In its restored medieval core, you'll discover one of France's oldest museums," +
                                                        " the MusÂe des Beaux-Arts, as well as the elegant Palace of the Dukes and the opulent 1614 mansion " +
                                                       "HÂtel de Vogue. Take a quiet walk through the lime- and chestnut-lined paths of Cours du Parc," +
                                                        " a green space dating to 1671, and don't forget to pair the region's rich history with its gastronomic delights. " });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Orléans.jpg", City = "Orléans",
                                        Description = "Orléans is a city on the banks of the Loire River in north-central France, and is capital of " +
                                                      "the Centre-Val de Loire region. Joan of Arc famously saved the city from English siege in 1429," +
                                                    " an event celebrated with an annual festival. A re-creation of the house where she stayed during " +
                                                      "the battle features multimedia exhibits on her life." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/ChâlonsEnChampagne.jpg", City = "ChâlonsEnChampagne",
                                        Description = "Châlons-en-Champagne is a city in France. It is the capital of both the department of Marne and " +
                                                      "the region of Champagne-Ardenne, despite being only a quarter " +
                                                        "the size of the city of Reims. Capital of the Marne department and the Champagne-Ardenne region " +
                                                      "in northeast France, Châlons-en-Champagne is a veritable City " +
                                                        "of Art and History. Criss-crossed by rivers and canals, it's no wonder it has earned the nickname " +
                                                      "Little Venice. Simply follow the current to discover its" +
                                                        " architectural and natural wonders. " });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Montpellier.jpg", City = "Montpellier",
                                        Description = "Getting sick on vacation is a major drag, but if you have to be under the weather, Montpellier is an " +
                                                      "ideal place to do it. People have studied medicine here for centuries—the" +
                                                    " Moors established medical schools in the 9th century, and the Université Montpellier’s school " +
                                                      "of medicine was founded in 1220. Once the local docs give you a clean bill of health" +
                                                     ", explore the cathedral, mansions and opera house. " });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Limoges.jpg", City = "Limoges",
                                         Description = " City of Art and History, Limoges also boasts architectural treasures and unusual sites, including a " +
                                                       "cemetery that is unique in Europe, a monumental train station, " +
                                                        "numerous parks and gardens. Capital of the Haute-Vienne department in the Limousin region, the city " +
                                                       "of Limoges lies on the banks of the Vienne River. It is celebrated " +
                                                        "mostly for its internationally renowned porcelain as well as its enamel and stained glass handicrafts." +
                                                       " Limoges is a city and commune, the capital of the Haute-Vienne " +
                                                        "department and the administrative capital of the Limousin région in west-central France. " });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Metz.jpg", City = "Metz",
                                        Description = "Metz offers many strolls through many gardens in the heart of the city and along the ramparts. The city " +
                                                      "reveals many treasures: one of the highest cathedrals in the gothic" +
                                                    " world, a mixed heritage of history and contemporary art, and the Centre Pompidou Metz, open since May 2010. " +
                                                      "Adding up friendliness and charm, that’s Metz. 34 km of walks along" +
                                                    " the banks of the Moselle and Seille rivers, and 5 golf clubs in a radius of 25 km, Metz, with its 37 m² of green " +
                                                      "space per habitant, prides itself on its parks and gardens. " +
                                                    " The leisure marina, in the heart of the city, has been raising the Pavillion Bleu flag since 2007. Right next to " +
                                                      "the Plan d’Eau, it is the starting point for many walks, loved by Messins and tourists alike." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Caen.jpg", City = "Caen",
                                        Description = "Caen is a major destination with a rich architectural heritage reflecting a thousand years of culture " +
                                                      "and history. Founded by William the Conqueror in the 11th century," +
                                                    " the city has some remarkable monuments, like its two monasteries, true jems of Roman art, or its Ducal " +
                                                      "castle, one of the largest fortified enclosures in Europe. Caen offers " +
                                                    "guests a unique setting, right in the heart of town, the maritime sweetness of its marina mixes with the " +
                                                      "green elegance of the racetrack and its many parks. Caen has a rich cultural " +
                                                    "life: there are many museums (The Caen Memorial, the Museum of Normandy or the Museum of Fine Arts) " +
                                                      "as well as a theater and the zenith." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Tolouse.jpg", City = "Tolouse",
                                        Description = "Toulouse is a city of contrasts with an exceptional heritage that offers the visitor plenty of " +
                                                      "pleasant surprises such as mansions from the Renaissance period which " +
                                                    "was the golden age of the town.  The city also hosts an amazing blend of brick and stone buildings " +
                                                      "and a rich collection of museums built within historical monuments" +
                                                    " or on former industrial sites. From place to place, along streets and monuments, la ville rose meets " +
                                                      "history and reveals all its charms.  At night, the city enlightens" +
                                                    " and Toulouse takes on a new face: the facades, the monuments and the river become the main characters " +
                                                      "of Toulouse’s magical evenings." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Lille.jpg", City = "Lille",
                                        Description = "Through the centuries, Lille was developed around the river Deûle. Located in the Flanders plain, " +
                                                      "the city has been strongly influenced politically and culturally, and" +
                                                    " some of them are still present on the façades of ancient architectures. Few places in France with such " +
                                                      "an architectural diversity: from Flanders to France passing by" +
                                                    " Burgundy and Spain, Lille was developed as an eclectic place,  rich from past but also present exchanges. " +
                                                      "Trading place from the Middle Ages, then an industrial place (19th and 20th centuries), Lille is today a" +
                                                      " tertiary place (services, trade center…) but also a touristic area. All activities reinforced by its exceptional " +
                                                      "location and the transport offers (TGV, Eurostar, Thalys, motorways, the international airport in Lesquin...)." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Nantes.jpg", City = "Nantes",
                                         Description = "Where in Nantes can you get a 360 degree view of the town and its suburbs perched 150 metres up? Which bit " +
                                                       "of modern art will give you the latest weather forecast?" +
                                                    " How many acres of green space will the Floral Gardens offer up to the heart of the town? Who are those people " +
                                                       "painted on the wall fallen from the sky? Welcome and" +
                                                    " enjoy your visit! You thought you knew the western most metropolis in Europe? You haven’t seen anything yet… " +
                                                       "Nantes Saint-Nazaire Estuary Trail On the 60kms of " +
                                                    "the Loire estuary, this open-air museum will take you on a voyage of discovery of this fascinating land " +
                                                       "and the rich environmental heritage it holds. In 2012, 8 new perennial installations will join the ranks " +
                                                       "along this arts trail and bring the total to 29 the number of artworks on show on the whole of its length." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Amiens.jpg", City = "Amiens",
                                        Description = "Whether you’re a history buff, garden lover, seeker of cultural events or a simple dreamer, Amiens " +
                                                      "has become the new essential weekend destination. Situated just" +
                                                    " under 2 hours from Paris. Amiens boasts a host of treasures awaiting your discovery, including " +
                                                      "the cathedral and belfry, both listed as UNESCO World Heritage sites, " +
                                                    "the hortillonnages gardens, Jules Verne’s house and the Saint-Leu district on the very edge of " +
                                                      "the water. All set in surroundings ideal to explore on foot or by bike. " +
                                                    "reat yourself to a weekend of surprises as you acquaint yourself with the many aspects of Picardy’s capital!" });
             
            locations.Add(new Location { CityImage = "Assets/LocationPictures/Poitiers.jpg", City = "Poitiers",
                                        Description = "History is omnipresent in Poitiers. From listed monuments to half-timbered houses, you will " +
                                                      "travel through time and also pass contemporary buildings that express" +
                                                    " the dynamism of the regional capital. Your exploration is guaranteed to be an enjoyable experience. " +
                                                      "Built during Antiquity on a rocky promontory around which two " +
                                                    "rivers flow, Poitiers has a heritage of immense richness that testifies to 2,000 years of history. " +
                                                      "Its centre has 78 buildings listed as historical monuments. " +
                                                    "Contemporary constructions stand alongside these treasures of the past. Their lines and curves fit " +
                                                      "into the harmony of its urban landscape." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Marseille.jpg", City = "Marseille",
                                        Description = "Founded in 600 BC by the Greeks from Phocaea, Marseille is the oldest city in France and the " +
                                                      "second largest after Paris. The city is home to almost 900,000" +
                                                    " people living in its 16 districts, most of which have held onto their authentic village atmosphere. " +
                                                      "Marseille has much to offer its locals and tourists: an " +
                                                    "incredible coastline, a harbour which turns foreign sailors green with envy and 300 days of sunshine " +
                                                      "every year! Marseille has an impressive natural heritage" +
                                                    " with numerous lush parks in the heart of the city, offering refreshing havens when the sun is beating down. " +
                                                      "Just a few kilometres from the Vieux-Port lies the " +
                                                    "Calanques National Park, which is the perfect spot for year-round outdoor activities. " +
                                                      "The famous Calanques cover 20 kilometres with untamed creeks to explore" +
                                                    " and clear blue water to enjoy." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Lyon.jpg", City = "Lyon",
                                        Description = "A two thousand year old city, situated at the junction of the Rhône and Saône rivers, Lyon rests " +
                                                      "below the impressive Fourvière and Croix Rousse hills. In Lyon, visitors " +
                                                        "can take a unique journey through time and across cultures, by strolling down its narrow streets, " +
                                                      "crossing its traboules (narrow secret passages), walking along its bustling" +
                                                        " docks, passing through its impressive squares, and seeing over 200 sites illuminated at night." });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Rouen.jpg", City = "Rouen",
                                        Description = "Rouen, historic capital of Normandy, opens you the doors of its open-air museum. Every hour of the day " +
                                                      "brings a procession of colors, constantly unveiling a different city" +
                                                    ". Near the cathedral, try and guess the famous paintings of Claude Monet, the stone facade reflecting the " +
                                                      "colors of the sun and the stained-glass windows permeating with" +
                                                    " light… In Rouen, you are definitely in the home of Impressionism. A walk through the streets of Rouen is a " +
                                                      "walk through the history and centuries of architectural development" +
                                                    " – the cathedral Notre Dame, St Ouen abbey, the Gros Horloge, the tourist office building, the Aître Saint-Maclou... " });

            locations.Add(new Location { CityImage = "Assets/LocationPictures/Ajaccio.jpg", City = "Ajaccio",
                                        Description = "Surrounded by a fantastic mountain range, Ajaccio is an elegant and sunny city, renowned for its long welcoming" +
                                                      " tradition. From the top of its citadel, it has preserved " +
                                                    "its bay which is one of the most beautiful in the world.  Strolling the lanes of the old town, you will discover its" +
                                                      " Napoleonic heritage, its prestigious museums, its daily" +
                                                    " market boasting so many flavours. Along the mysterious way to the Sanguinary islands you will find gorgeous beaches " +
                                                      "and wild creeks. You will be fascinated by this little archipelago, " +
                                                    "standing guard at the mouth of the bay, especially at sunset when it turns to a fantastic crimson colour." });


            return locations;
        }

    }
}
