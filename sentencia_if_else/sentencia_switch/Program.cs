using System;

namespace sentencia_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 5;
            switch (op)
            {
                case 1:
                    Console.WriteLine("selecionaste 1");
                    break;
                case 2:
                    Console.WriteLine("selecionaste 2");
                    break;
                case 3:
                case 4:
                    Console.WriteLine("selecionaste 3 o 4");
                    break;
                default:
                    Console.WriteLine("invalido");
                    break;
            }
        }
    }
}
