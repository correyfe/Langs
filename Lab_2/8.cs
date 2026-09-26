using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        if (age < 0)
        {
            Console.WriteLine("Error!");
        }
        else if (age <= 12)
        {
            Console.WriteLine("Child");
        }
        else if (age <= 17)
        {
            Console.WriteLine("Teenage");
        }
        else if (age <= 64)
        {
            Console.WriteLine("Adult");
        }
        else
        {
            Console.WriteLine("Aged");
        }
    }
}