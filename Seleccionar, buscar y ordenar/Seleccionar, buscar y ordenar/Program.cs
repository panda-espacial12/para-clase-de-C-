using System;
using System.Collections.Generic;
using System.Linq;

namespace Seleccionar__buscar_y_ordenar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Beer> beers = new List<Beer>()
            {
                new Beer() { Name = "Corona", Country = "Mexico" },
                new Beer() { Name = "Delirium", Country = "Belgica" },
                new Beer() { Name = "Erdinger", Country = "Alemania" }
            };

            foreach (var beer in beers)
            {
                Console.WriteLine(beer);
                Console.WriteLine("-----------");

                // Select
                var beersName = from b in beers
                                select new
                                {
                                    Name = b.Name,
                                    Letters = b.Name.Length,
                                    Fixed = 1
                                };

                foreach (var beerName in beersName)
                    Console.WriteLine($"{beerName.Name} {beerName.Letters} {beerName.Fixed}");

                Console.WriteLine("-----------");

                var beersNameReal = from b in beersName
                                    select new
                                    {
                                        Name = b.Name
                                    };

                foreach (var beerName in beersNameReal)
                    Console.WriteLine(beerName.Name);

                Console.WriteLine("-----------");

                // Filtrar por país
                var beersMexico = from b in beers
                                  where b.Country == "Mexico" || b.Country == "Alemania"
                                  select b;

                foreach (var beerCountry in beersMexico)
                    Console.WriteLine(beerCountry);

                Console.WriteLine("-----------");

                // Ordenar por país
                var orderedBeers = from b in beers
                                   orderby b.Country
                                   select b;

                // foreach (var beer in orderedBeers)
                  //  Console.WriteLine(beer);

                // Console.WriteLine("-----------");
            }
        }
    }

    public class Beer
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name} Pais: {Country}";
        }
    }
}
