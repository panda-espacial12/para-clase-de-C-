using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string json = "{\"Name\": \"lol\", \"brand\" : \"snow\"}";

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
        }
          

        public class beer
        {
            public string Name { get; set; }

            public string brand { get; set; }
        }
    }
}
