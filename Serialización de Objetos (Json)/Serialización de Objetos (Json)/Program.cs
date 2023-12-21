using System;
using System.Text.Json;

namespace formato_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            beer mybeer = new beer()
            {
                Name = "lol",
                brand = "snow"
            };

            string json2 = JsonSerializer.Serialize(beers);
            beer[] beers2 = JsonSerializer.Deserialize<beer[]>(json2);


            beer[] beers = new beer[]
            {
                new beer()
                {
                    Name = "lol",
                    brand = "snow"
                },
                new beer()
                {
                    Name = "corona",
                    brand = "modelo"
                }
            };

            string json2 = JsonSerializer.Serialize(beers);
            beer[] beers2 = JsonSerializer.Deserialize<beer[]>(json2);
        }

        public class beer
        {
            public string Name { get; set; }

            public string brand { get; set; }
        }
    }
}
