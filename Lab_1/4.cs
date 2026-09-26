/*4) Даны целые положительные числа A и B (A > B). 
На отрезке длины A размещено максимально возможное количество 
отрезков длины B (без наложений). Используя операцию деления нацело,
 найти количество отрезков B, размещенных на отрезке AB.  */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(a / b);

    }
}