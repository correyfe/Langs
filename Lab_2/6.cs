using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter yout score: ");
        int s = int.Parse(Console.ReadLine());

        if (s >= 90 && s <= 100)
        {
            Console.WriteLine("Отл");
        }
        else if (s >= 75 && s < 90)
        {
            Console.WriteLine("Хор");
        }
        else if (s >= 60 && s < 75)
        {
            Console.WriteLine("Уд");
        }
        else if (s >= 0 && s < 60)
        {
            Console.WriteLine("Неуд");
        }
        else
        {
            Console.WriteLine("You are lying");
        }
    }
}