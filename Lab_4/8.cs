/*8. Заполнить массив A на 10 элементов случайными числами от 0 до 45. Вывести его.
    Вывести первый элемент массива, который больше X, и вывести его значение и индекс. 
    Если такого нет — вывести сообщение об отсутствии.*/

class Program
{
    static void Main()
    {
        int[] A = new int[10];
        int number = 0;
        int index = 0;
        int flag = 0;

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(0, 46);

            Console.Write($"{A[i]} ");

            if (A[i] > 10 && flag == 0)
            {   
                number = A[i];
                index = i;
                flag = 1;
            }
        }

        if (flag == 0)
        {
            Console.WriteLine("No number bigger than 10!");
        }
        else
        {
            Console.WriteLine($"Number: {number}, Index: {index}");
        }
    }
}