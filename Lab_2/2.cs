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
            func = x; 
        }
        else if (x > 0 && x <= 5)
        {
            func = x * x;
        }
        else
        {
            func = x * x * x;
        }

        Console.WriteLine(func);
    }
}