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
           
            
            using (CsharpDBContext context = new CsharpDBContext(optionBuilder.Options))
            {
                var beers = context.beers.ToList();

                foreach (var beer in beers)
                {
                    Console.WriteLine(beer.Name);
                }
            }

         
        }
        class A
        {

        }
    }
}
