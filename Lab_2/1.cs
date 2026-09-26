using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        int func;

        if (x <= 3)
        {
            func = (7 * x) + 25; 
        }
        else if (x > 3 && x <= 80)
        {
            func = x * x;
        }
        else
        {
            func = -1 * (x * x);
        }

        Console.WriteLine(func);
    }
}