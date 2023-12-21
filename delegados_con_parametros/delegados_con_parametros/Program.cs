using System;

public delegate int Operation(int a, int b);
public delegate void Show(string message);

class Program
{
    static void Main()
    {
        Operation mySum = Functions.Sum;

        Console.WriteLine(mySum(2, 3));

        mySum = Functions.Mul;
        Console.WriteLine(mySum(2, 3));

        Show cw = Console.WriteLine;
        cw += Functions.ConsoleShow;
        cw("hola mundo");

        // Mover la llamada a Some dentro del método Main
        Functions.Some("anakin", "skywalker", cw);
    }
}

public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int x, int y) => x * y;
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());
    public static void Some(string name, string lastName, Show fn)
    {
        Console.WriteLine("hago algo al inicio");
        fn($"hola {name} {lastName}");
        Console.WriteLine("hago algo al final");
    }
}



/////                 ERRROR SEGUN LA VERSION  //////////////////
////////////////////////////////////////////////////////////////

//using System;

//Functions.Some("anakin", "skywallker", cw);

//delegate int Operation(int a, int b);
//public delegate void Show(string message);

//class Program
//{
//static void Main()
//{
//Operation mySum = Functions.Sum;

//Console.WriteLine(mySum(2, 3));
//
// /mySum = Functions.Mul;
//Console.WriteLine(mySum(2, 3));

//Show cw = Console.WriteLine;
//cw += Functions.ConsoleShow;
//cw("hola mundo");
//    }
//}

//public class Functions
//{
//public static int Sum(int x, int y) => x + y;
//public static int Mul(int x, int y) => x * y;
//public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());
//public static void Some(string name, string lastName, Show fn)
//{
//Console.WriteLine("hago algo al inicio"); // Corregir aquí
//fn($"hola {name} {lastName}");
//Console.WriteLine("hago algo al final");
//    }

//}