/*7. Заполнить массив A на 10 элементов случайными числами от 0 до 70. Вывести его. 
    Вывести элементы массива кратные семи, и не кратные трём*/

class Program
{
    static void Main()
    {
        int[] A = new int[10];

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(0, 71);

            Console.Write($"{A[i]} ");

            if (A[i] % 7 == 0 && A[i] % 3 != 0)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}