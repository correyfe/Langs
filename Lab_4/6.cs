/*6. Заполнить массив A на 20 элементов случайными числами от -30 до 30. Вывести его. 
    Посчитать, сколько элементов массива попадают в диапазон от -10 до 10.*/

class Program
{
    static void Main()
    {
        int[] A = new int[20];
        int count = 0;

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(-30, 31);

            Console.Write($"{A[i]} ");

            if (A[i] <= 10 && A[i] >= -10)
            {
                count += 1;
            }
        }
        Console.WriteLine($"Count: {count}");
    }
}