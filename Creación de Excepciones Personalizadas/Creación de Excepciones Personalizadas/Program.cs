using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creación_de_Excepciones_Personalizadas
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                beer beer = new beer()
            {
                Name = "London Porter",
                //Brand = "Faller´s"
            };

                Console.WriteLine(beer);
            }
            catch(invalidBeerExeption ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public class invalidBeerExeption : Exception
        {
            public invalidBeerExeption() :
                base("la cerveza no tiene nombre ni marca es invalida ")
            {
                
            }
        }

        public class beer
        {
            public string Name { get; set; } 

            public string Brand { get; set; }

            public override string ToString()
            {
                if (Name == null || Brand == null)

                    throw new invalidBeerExeption();

                return $"cerveza {Name}, Brand: {Brand}";
            }
        }
    }
}
