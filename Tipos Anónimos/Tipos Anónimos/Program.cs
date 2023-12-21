using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_Anónimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var hector = new
            {
                Name = "hector",
                Country = "mexico"
            };

            Console.WriteLine($"{hector.Name}, {hector.Country}");

            var beers = new[]
            {
                new { Name = "Red", Brand = "Delirium"},
                new { Name = "London Porter", Brand = "flullers"}
            };

            foreach (var b in beers)
            {
                Console.WriteLine($"cerbeza {b.Name} {b.Brand}");
            }
        }
    }
}
