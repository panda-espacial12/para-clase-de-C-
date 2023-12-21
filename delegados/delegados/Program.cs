using System;

delegate int Operation(int a, int b);
delegate void Show(string message);

class Program
{
    static void Main()
    {
        Operation mySum = Functions.Sum;

        Console.WriteLine(mySum(2, 3));

        mySum = Functions.Mul;
        Console.WriteLine(mySum(2, 3));

        Show cw = Console.WriteLine;
        cw("hola mundo");
    }
}

public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int x, int y) => x * y;
    public static void ConsoleShow(string m) => Console.WriteLine(m);
}


///////// codigo con error segun la version 
/////////////////////////////////////////////////////////////

//using System;

//Operation mySum = Funtions.Sum;

//Console.WriteLine(mySum(2,3));
//mySum = Funtions.Mul;
//Console.WriteLine(mySum(2, 3));

//Show cw = Console.WriteLine;
//cw("hola mundo");

//delegate int Operation(int a, int b);
//delegate void Show(string message);

//public class Funtions
//{
//    public static int Sum(int x, int y) => x + y;
//public static int Mul(int X, int y) => X + y;
//public static void ConsoleShow(string m) => Console.WriteLine(m);
//}
