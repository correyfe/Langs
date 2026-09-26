using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        int func;

        if (x <= -30)
        {
            func = 7 * x; 
        }
        else if (x > -30 && x <= 0)
        {
            func = x * x * x;
        }
        else
        {
            func = -1 * (x * x);
        }

        Console.WriteLine(func);
    }
}