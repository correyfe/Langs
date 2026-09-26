/*5) Дано трехзначное число. Найти сумму и произведение его цифр. */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        int sum = 0;
        int pr = 1;
        
        for (int i = 1; i <= 3; i++)
        {
            int n = a % 10;
            sum += n;
            pr *= n;
            a /= 10;
        }

        Console.WriteLine("{0}, {1}", sum, pr);
    }
}