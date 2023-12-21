using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Union__Join_
{
    class Program
    {
        static void Main(string[] args)
        {
            var beers = new List<Beer>()
            {
                new Beer()
                {
                    Name="Corona", Country="Mexico"
                },

                //2 Beer
                new Beer()
                {
                    Name="Delirium", Country="Belgica"
                },

                //3 Beer
                new Beer()
                {
                    Name="Erdinger", Country="Alemania"
                },
            };

            var Countryes = new List<Country>()
            {
                new Country()
                {
                    Name = "Mexico",Continent = "America"
                },

                //2 Country
                new Country()
                {
                    Name = "Belgica",Continent = "Europa"
                },

                //3 Country 
                new Country()
                {
                    Name = "Alemania",Continent = "Europa"
                },
            };

            var beersWithContinent = from beer in beers
                                     join Country in Countryes
                                     on beer.Country equals Country.Name
                                     select new
                                     {
                                         name = beer.Name,
                                         Country = beer.Country,
                                         Continent = Country.Continent
                                     };
            foreach (var beer in beersWithContinent)
                Console.WriteLine($"{beer.name} {beer.Country} {beer.Continent}");
        }

        public class Beer
        {
            public string Name { get; set; }

            public string Country { get; set; }

        }


        public class Country
        {
            public string Name { get; set; }

            public string Continent { get; set; }
        }
    }
}
