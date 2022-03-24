using System;

class MainClass
{
    static void Main(string[] args)
    {
        const string MyName = "Jane";

        Console.WriteLine(MyName);

        Console.WriteLine("Привет, мир");
        Console.WriteLine("Мне 27 лет");
        Console.WriteLine("My name is Jane");
        Console.WriteLine('\u0040');
        Console.WriteLine('\x23');
        Console.ReadKey();
    }
}