/*4. Заполнить массив A на 20 элементов случайными числами от -5 до 25. Вывести его. 
    Напечатать сумму элементов с чётными индексами.*/

class Program
{
    static void Main()
    {
        int[] A = new int[20];
        int count = 0;

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(-5, 26);

            Console.Write($"{A[i]} ");

            if (i % 2 == 0)
            {
                count += A[i];
            }
        }
        
        Console.WriteLine($"\ncount: {count}");
    }
}