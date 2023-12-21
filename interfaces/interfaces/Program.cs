using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] sharks = new Shark[]
            {
                 new Shark("tiburonsin",56) ,
                 new Shark("jaws", 65)
            };

            IFish[] fish = new IFish[]
            {
                new Siren (100),
                new Shark("tiburonsin", 56)
            };

            ShowFish(sharks);
            ShowFish(fish);
            ShowFish(sharks);
        }
    
        static void ShowFish(IFish[] fishs)
        {
            Console.WriteLine("- mostramos los peces -- ");
            int i = 0;
            while (i < fishs.Length)
            {
                Console.WriteLine(fishs[i].Swim());
                i++;
            }
        }

        public class Siren : IFish
        {
            public int Speed { get; set; }


            public Siren(int Speed)
            {
                this.Speed = Speed;
            }

            public string Swim()
            {
                return $"LA SIRENA nada a {Speed}km/h";
            }
        }
        public class Shark : IAnimal, IFish
        {
            public string Name { get; set; }

            public int Speed { get; set; }

            public Shark(string Name, int Speed)
            {
                this.Name = Name;
                this.Speed = Speed;
            }

            public string Swim()
            {
                return $"{Name} nada {Speed} km/h";
            }
        }

        public interface IAnimal
        {
             string Name { get; set; }
        }

        public interface IFish
        {
             int Speed { get; set; }

             string Swim();
        }

    }
}
