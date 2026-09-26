/*1. Заполнить массив A на 10 элементов случайными числами от -20 до 20. Вывести его. 
    Напечатать сумму и количество отрицательных чисел.*/

class Program
{
    static void Main()
    {
        int[] A = new int[10];
        int count = 0;
        int sum = 0;

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(-20, 21);
            Console.Write($"{A[i]} ");

            if (A[i] < 0)
            {
                count += 1;
                sum += A[i];
            }
        }

        Console.WriteLine($"\nCount: {count}, Sum: {sum}");
    }
}
