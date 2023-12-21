using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale mysale = new Sale(100, DateTime.Now);
            mysale.total = -12345;
            Console.WriteLine(mysale.total);
        }

        class Sale
        {
            private int total;
            DateTime date;


            public int total
            {
                get
                {
                    return total;
                }
                set
                {
                    if (value < 0)
                        value = 0;
                    total = value;
                }

            }
            public Sale(int total, DateTime date)
            {
                this.total = total;
                this.date = date;

            }
        }
    }
}