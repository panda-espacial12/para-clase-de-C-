using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentencia_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 5;
            var numbers = new List<int>()
            {
                23,3,5,10,22,12
            };



            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            var students = new List<People>()
            {
                new People() { Name = "Hector", Country = "Mexico" },
                new People() { Name = "Roberto", Country = "Argentina" },
                new People() { Name = "Anna", Country = "Estados unidos"},
            };

            Show(students);

        }
        static void Show(List<People> students)
        {
            Console.WriteLine("-- persona --");
            foreach (var People in students)
            {
                Console.WriteLine($"nombre: {People.Name}, Pais De Origen: {People.Country}");
            }
        }

        class People
        {
            public string Name { get; set; }

            public string Country { get; set; }
        }
    }
}
