/*9. Заполнить массив A на 10 элементов случайными числами от -15 до 15. Вывести его.
    Вывести произведение всех положительных элементов массива.
    Если положительных нет — вернуть 1 или вывести специальное сообщение.*/

class Program
{
    static void Main()
    {
        int[] A = new int[10];
        int pr = 1;

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(-15, 16);

            Console.Write($"{A[i]} ");

            if (A[i] > 0)
            {
                pr *= A[i];
            }
        }

        Console.WriteLine(pr);
    }
}