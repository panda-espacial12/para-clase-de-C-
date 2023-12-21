using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

class Program
{
    static void Main()
    {
        #region action
       // string hi = "hola";
        Action<string> ShowMessage = Console.WriteLine;
        Action<string, string> ShowMessage2 = (a, b) =>
        {
            Console.WriteLine($"{a} {b}");
           // Console.WriteLine($"{hi} {a} {b}");
        };
        Action<string, string, string> ShowMessage3 = (a, b, c) => Console.WriteLine($"{a} {b} {c}");

        ///ShowMessage2("george", "rr martin");
        ////ShowMessage3("george", "rr martin", "dev");
        //Functions.SomeAction("george", "rr martin", (a) =>
        //{
         ///Console.WriteLine("soy una expresión lambda" + a);
       // });

        //Functions.SomeAction("Hector", "Leon", ShowMessage);
        #endregion

        #region func
        Func<int> numberRamdom = () => new Random().Next(0, 100);
        Func<int, int> numberRamdomLimit = (limit) => new Random().Next(0, limit);


#region predicate
Predicate<string> hasSpaceOrA = (word) => word.Contains(" ")  || word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceOrA("beear"));
Console.WriteLine(hasSpaceOrA("p ati to"));

        var words = new List<string>()
        {
            "beer",
            "patito",
            "sandia",
            "hola mundo",
            "c#"
        };
        var wordsNew = words.FindAll((w)=>!hasSpaceOrA(w));
        foreach (var w in wordsNew) Console.WriteLine(w); 
#endregion


        // Console.WriteLine(numberRamdom());
        // Console.WriteLine(numberRamdomLimit(100000));
        #endregion


    }
}

public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Mul(int x, int y) => x * y;
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    public static void Some(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("hago algo al inicio");
        string value = $"hola {name} {lastName}";
        Console.WriteLine(value);
        Console.WriteLine("hago algo al final");
    }

    public static void SomeAction(string name, string lastName, Action<string> fn)
    {
        Console.WriteLine("ago al al principio");
        fn($"hola {name} {lastName}");
        Console.WriteLine("ago algo al final");
    }
}
