using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Métodos_comunes_de_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
              3,4,5,19
            };
          
            show(numbers);

            //insert
            numbers.Insert(1, 6);
            show(numbers);

            //contains
            if (numbers.Contains((19)))
                Console.WriteLine("existe");
            else
                Console.WriteLine("no existe");

            //indexOf
            int pos = numbers.IndexOf(19);
            Console.WriteLine(pos);

            //sort
            numbers.Sort();
            show(numbers);

            // add range
                var numbers2 = new List<int>()
                {
                    300,200,400
                };

            numbers.AddRange(new List<int>()
            {
                200,300,400
            });


            numbers.AddRange(numbers2);

            show(numbers);

        }

        public static void show(List<int> numbers)
        {
            Console.WriteLine("-- numeros --");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}
