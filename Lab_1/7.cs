/*7) Дано трехзначное число. В нем зачеркнули первую слева цифру
 и приписали ее справа. Вывести полученное число.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write(a % 100);
        Console.WriteLine(a / 100);
        
    }
}