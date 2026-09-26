/*3. Заполнить массив A на 10 элементов случайными числами от -30 до 10. Вывести его. 
    Напечатать количество чётных и нечётных элементов.*/

class Program
{
    static void Main()
    {
        int[] A = new int[10];
        int even_count = 0; // четный
        int odd_count = 0; // нечетный

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(-30, 11);

            Console.Write($"{A[i]} ");

            if (A[i] % 2 == 0)
            {
                even_count +=1;
            }
            else
            {
                odd_count += 1;
            }
        }
        
        Console.WriteLine($"\nЧетных: {even_count} Нечетных: {odd_count}");
    }
}