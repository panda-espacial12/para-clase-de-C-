
using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BD;
using System.Threading.Tasks;
using Microsoft.EntityFreanworkCore;
using System.Runtime.Remoting.Contexts;

namespace Utilización_de_Entity_Framework
{
    class Program
    {
        static void Main(string[] args)
        {
            dBContextOptionsBuilder<CsharpDBContext> optionBuilder =
                new DbContextOptionsBuilder<CsharpDBContext>();
            optionBuilder.UseSqlServer("server=DITOXLAP02\\SQLEXPRESS03;DATABASE=CsharpDB;Trusted_Connection=True;");

            bool again = true;
            int op = 0;

            do
            {
                showmenu();
                Console.WriteLine("elige una opcion");
                op = int.parse(Console.readLine());

                switch (op)
                {
                    case:show(optionBuilder);
                        break;
                }
            } while (again);
        }
       public static void showmenu()
        {
            Console.WriteLine("\n---------menu-------");
            Console.WriteLine("1.- mostrar ");
            Console.WriteLine("2.- ageagar");
            Console.WriteLine("3.- editar");
            Console.WriteLine("4.- eliminar");
            Console.WriteLine("5.- salir");
        }
       
    }
}
