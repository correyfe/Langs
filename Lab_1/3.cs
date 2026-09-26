/* 3) Известно, что X кг шоколадных конфет стоит A рублей, 
а Y кг ирисок стоит B рублей. Определить, сколько стоит 1 кг 
шоколадных конфет, 1 кг ирисок,
 а также во сколько раз шоколадные конфеты дороже ирисок. */

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter X: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter Y: ");
        int y = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter B: ");
        int b = int.Parse(Console.ReadLine());

        float choco_cost = a / x;
        float iris_cost = b / y;

        float diff = choco_cost / iris_cost;

        Console.WriteLine("Choco: {0}, Iris: {1}, Difference: {2}", choco_cost, iris_cost, diff);
    }
}