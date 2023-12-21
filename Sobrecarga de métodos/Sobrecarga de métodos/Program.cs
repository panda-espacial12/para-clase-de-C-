using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga_de_métodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.sum(1,2));
            Console.WriteLine(math.sum(1, 2));

            int[] numbers = new int[] { 1, 2, 5 };
            Console.WriteLine(math.sum(numbers));
        }

    }
    public class Math
    {
        public int sum(int a, int b)
        {
            return a + b;
        }

        public int sum(string a, string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        public int sum(int[] nombre)
        {
            int result = 0;
            int i = 0;

            while(i <numbers.length)
            {
                result += <numbers[i];
                i++; ;
            }

            return result;
        }
    }
}
