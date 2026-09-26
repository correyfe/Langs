using System;


class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        int b = int.Parse(Console.ReadLine());

        int c = (a * a) + (b * b);
        int p = a + b + c;

        Console.WriteLine("C = {0}, P = {1}", c, p);
    }
}