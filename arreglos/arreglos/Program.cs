using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[8]{
                "ruben",
                "calos",
                "luis",
                "pedro",
                "jon",
                null,
                "jorge",
                null
                };

            int index = 0;
           while (index < friends.Length)
            {
                Console.WriteLine(friends[index]);
                index ++;
            }
        }
    }
}

