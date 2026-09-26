/*2. Заполнить массив A на 20 элементов случайными числами от 0 до 50. Вывести его.
    Напечатать максимальное и минимальное число.*/

class Program
{
    static void Main()
    {
        int[] A = new int[20];
        int max = 0;
        int min = 50;

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(0, 51);
            Console.Write($"{A[i]} ");

            if (A[i] < min)
            {
                min = A[i];
            }

            if (A[i] > max)
            {
                max = A[i];
            }
        }

        Console.WriteLine($"\nmax: {max}, min: {min}");
    }
}
