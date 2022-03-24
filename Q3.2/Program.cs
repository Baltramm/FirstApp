using System;

class MainClass
{
    static void Main(string[] args)
    {
		Console.WriteLine("Как вас зовут?");
        var name = Console.ReadLine();
        Console.WriteLine("Сколько вам лет?");
        var age = Console.ReadLine();
        Console.WriteLine("Здравствуйте, {0} , Вам {1} лет", name,age);
        Console.WriteLine("Введите вашу дату рождения");
        var birthdate = Console.ReadLine();
        Console.WriteLine("Вы родились {0}",birthdate);
    }

}