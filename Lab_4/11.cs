using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        int[] A = new int[n];
        int[] B = new int[m];
        int[] C = new int[n+m];

        for (int i = 0; i < A.Length; i++)
        {
            A[i] = Random.Shared.Next(-20, 21);
            Console.Write($"{A[i]} ");
        }
        Console.Write("\n");

        for (int i = 0; i < B.Length; i++)
        {
            B[i] = Random.Shared.Next(-20, 21);
            Console.Write($"{B[i]} ");
        }
        Console.Write("\n");

        for (int i = 0; i < C.Length; i++)
        {
            if (i < n)
            {
                C[i] = A[i];
            }
            else
            {
                C[i] = B[i - n];
            }
            Console.Write($"{C[i]} ");
        }
    }
}