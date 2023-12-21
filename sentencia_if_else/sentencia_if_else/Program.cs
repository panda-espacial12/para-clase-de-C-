using System;

namespace funcion_si
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tengohambre = true;
            bool tengodinero = true;

            if (tengohambre && tengodinero && abierto ("24 hour",7))// se usa para decir and y  se tienen que cumplir ambas condiciones
                                           // if (tengohambre || tengodinero)// ( || ) se usa para decir or es decir que se debe cumplir una o otra condicion 
            {
                Console.WriteLine("come");
            }
            else
            {
                Console.WriteLine("no comes");
            }
        }

        static bool abierto(string name, int hour = 0)
        {
            if ( name == "pepe" && hour > 8 &&  hour < 23)
            {
                return true;
            }else if (name == "24 hour")
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
