using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the time: ");
        int time = int.Parse(Console.ReadLine());

        if (time >= 0 && time <= 23)
        {
            if (time <= 5)
            {
                Console.WriteLine("Ночь");
            }
            else if (time <= 11)
            {
                Console.WriteLine("Утро");
            }
            else if (time <= 17)
            {
                Console.WriteLine("День");
            }
            else
            {
                Console.WriteLine("Вечер");
            }
        }
        else
        {
            Console.WriteLine("Wrong time!!!");
        }
    }
}