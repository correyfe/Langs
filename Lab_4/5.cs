/*5. Заполнить массив A на 10 элементов случайными числами от -10 до 10. Вывести его. 
    Заменить отрицательные элементы на ноль и вывести обновлённый массив.*/

class Program
{
    static void Main()
    {
        int[] A = new int[10];
        int[] A_new = new int[10];

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(-10, 11);

            Console.Write($"{A[i], 3} ");

            if (A[i] < 0)
            {
                A_new[i] = 0;
            }
            else
            {
                A_new[i] = A[i];
            }
            
            Console.WriteLine(A_new[i]);
        }
    }
}