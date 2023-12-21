using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Explicación_de_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\Alex\Desktop\practica  html css python linux etc\c#\Explicación de Excepciones\hola.txt");
                Console.WriteLine(content);

                string content2 = File.ReadAllText(@"C:\Users\Alex\Desktop\practica  html css python linux etc\c#\Explicación de Excepciones\hola2.txt");
                Console.WriteLine(content2);

                throw new Exception("ocurio algo raro");
            }



            catch (FileNotFoundException ex)
            {
                Console.WriteLine("el archivo no existe");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("aqui me he ejecutado");
            }

            Console.WriteLine("aqui se sigue ejecutando");
        }
    }
}
