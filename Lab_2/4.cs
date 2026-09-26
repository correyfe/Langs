using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        int func;

        if (x <= 0)
        {
            func = 0; 
        }
        else if (x > 0 && x <= 10)
        {
            func = x * x;
        }
        else
        {
            func = (-1 * (x * x)) + x;
        }

        Console.WriteLine(func);
    }
}