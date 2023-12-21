using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>(10);
            numbers.add(10);
            numbers.add(6);

            MyList<string> strings = new MyList<string>(10);
            strings.add("hector");

            MyList<people> people = new MyList<people>(5);
            people.add(new Generics.people() { Name = "hector", country = "mexico" });
            people.add(new Generics.people() { Name = "juan", country = "argentina" });


            Console.WriteLine(numbers.GetString());
            Console.WriteLine(strings.GetString());
            Console.WriteLine(people.GetString());
            Console.WriteLine(numbers.GetElement(11));
            Console.WriteLine(strings.GetElement(0));
        }
    }

    public class people
    {
        public string Name { get; set; }

        public string country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name}, pais {country}";
        }
    }

    public class MyList<t>
    {
        private t[] _elements;
        private int _index = 0;

        public MyList(int n)
        {
            _elements = new t[n];
        }

        public void add(t e)
        {
            _elements[_index] = e;
            _index++;
        }


        public t GetElement(int i)
        {
            if (i <= _index && i >= 0)
            {
                return _elements[i];
            }

            return default(t);
        } 

        public string GetString()
        {
            int i = 0;
            string result = "";
            while(i<_index)
            {
                result += _elements[i].ToString() + "|";
                i++;
            }
            return result;
        }
        
    }
}
