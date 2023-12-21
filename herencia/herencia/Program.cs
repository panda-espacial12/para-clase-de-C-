using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("house", 40, "cardiologo");
            Console.WriteLine(doctor1.Getinfo());
            Console.WriteLine(doctor1.GetData());

        }

        class people
        {
            private string _name;
            private string _age;
            public people(String name, int age)
            {
                _name = name;
                _age = age;
            }

            public string Getinfo()
            {
                return _name + " " + _age;
            }
        }


        class Doctor : people
        {
            private string _speciality;
            public Doctor(string name, int age, string speciality) : base(name, age)
            {
                _speciality = speciality;
            }
            
            public string GetData()
            {
                return Getinfo() + " " + _speciality;
            }
        }
    }
}
