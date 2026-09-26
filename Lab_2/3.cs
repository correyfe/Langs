using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        int func;

        if (x <= -2)
        {
            func = x * x; 
        }
        else if (x > -2 && x <= 10)
        {
            func = (2 * x) + 1;
        }
        else
        {
            func = -1 * x;
        }

        Console.WriteLine(func);
    }
}