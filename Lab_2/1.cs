using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        if (x <= 3)
        {
            Console.WriteLine((7 * x) + 25);
        }
        else if (x > 3 && x <= 80)
        {
            Console.WriteLine(x * x);
        }
        else
        {
            Console.WriteLine(-1 * (x * x));
        }

    }
}