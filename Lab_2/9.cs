using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your status: ");
        string status = Console.ReadLine();

        Console.Write("Price: ");
        int price = int.Parse(Console.ReadLine());

        if (status == "обычный")
        {
            Console.WriteLine(price);
        }
        else if (status == "постоянный")
        {
            Console.WriteLine(price * 0.90);
        }
        else if (status == "VIP")
        {
            Console.WriteLine(price * 0.80);
        }
        else
        {
            Console.WriteLine("Wrong status!");
        }

    }
}