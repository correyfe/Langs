/*6) Дано трехзначное число. Вывести число, полученное 
при прочтении исходного числа справа налево. */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 3; i++)
        {
            Console.Write(a % 10);
            a /= 10;
        }
        Console.WriteLine();
    }
}