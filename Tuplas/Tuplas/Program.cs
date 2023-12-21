using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) product = (1, " cerveza stoud");

            Console.WriteLine($"{product.id} {product.name}");

            product.name = "cerbeza porter";

            Console.WriteLine($"{product.id} {product.name}");

            var person = (1, "hector");
            Console.WriteLine($"persona {person.Item1} {person.Item2}");

            var people = new[]
            {
                (1, "hector"),
                (2, "pedro"),
                (3, "juan")
            };
            foreach (var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            (int id, string name)[] people2 = new[]
            {
                (1, "hector"),
                (2, "pedro"),
                (3, "juan")
            };

            foreach (var p in people2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }
            var cityinfo = getLocationCDMX();
            Console.WriteLine($"lat: {cityinfo.lat} long: {cityinfo.ing} nombre: {cityinfo.name}");

            var (_, ing, _) = getLocationCDMX();

            Console.WriteLine(ing);
        }

        public static (float lat, float ing, string name) getLocationCDMX()
        {
            float lat = 19.121212f;
            float ing = -99.19212f;
            string name = "CDMX";

            return (lat, ing, name);
        }
    }
}
