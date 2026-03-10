using System;

class PascalTriangle
{
    static void Main()
    {
        Console.Write("Δώσε ύψος τριγώνου: ");
        int height = int.Parse(Console.ReadLine());

        long[,] dp = new long[height, height];

        for (int i = 0; i < height; i++)
        {
            dp[i, 0] = 1;
            for (int j = 1; j <= i; j++)
                dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
        }

        // Εκτύπωση
        for (int i = 0; i < height; i++)
        {
            Console.Write(new string('*', (height - i - 1) * 2));
            for (int j = 0; j <= i; j++)
                Console.Write($" {dp[i, j],4} ");
            Console.Write(new string('*', (height - i - 1) * 2));
            Console.WriteLine();
        }
    }
}