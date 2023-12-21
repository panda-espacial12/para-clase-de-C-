using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[6]
            {
                "pancho",
                "paco",
                "anna",
                "ruben",
                "karla",
                "luis",
            };

            bool run = true;
                for(int i = 0; i< friends.Length && run ; i++)
            {
                Console.WriteLine(friends[i]);
            }
        }
    }
}
