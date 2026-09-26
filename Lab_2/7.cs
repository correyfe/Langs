using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        if ((a < b + c) && (b < a + c) && (c < a + b))
        {
            if (a == b && b == c)
            {
                Console.WriteLine("Равносторонний треугольник");
            }
            else if ((a == b && a != c) || (a == c && a != b) || (c == b && c != a))
            {
                Console.WriteLine("Равнобедренный треугольник");
            }
            else
            {
                Console.WriteLine("Разносторонний треугольник");
            }
        }
        else
        {
            Console.WriteLine("Это не треугольник");
        }
    }
}