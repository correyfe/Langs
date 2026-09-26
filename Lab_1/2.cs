/* 2) Даны два круга с общим центром и радиусами R1 и R2 (R1 > R2). 
Найти площади этих кругов S1 и S2, а также площадь S3 кольца,
внешний радиус которого равен R1, а внутренний радиус равен R2.  */
using System;
using static System.Math;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter R1: ");
        double r1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter R2: ");
        double r2 = double.Parse(Console.ReadLine());

        double s1 = PI * r1 * r1;
        double s2 = PI * r2 * r2;
        double s3 = s1 - s2;

        Console.WriteLine("S1 = {0:F2}, S2 = {1:F2}, S3 = {2:F2}", s1, s2, s3);
    }
}