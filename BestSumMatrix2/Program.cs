using System;

class MaxSubmatrixSum
{
    static void Main()
    {
        int[,] matrix = {
            { 2, 5, 7, 7, 2 },
            { 4, 1, 3, 6, 5 },
            { 2, 8, 7, 8, 8 },
            { 0, 4, 3, 2, 4 },
            { 2, 1, 1, 9, 8 }
        };

        int rows = matrix.GetLength(0); // 5
        int cols = matrix.GetLength(1); // 5
        int subRows = 2; // ύψος υποπίνακα
        int subCols = 3; // πλάτος υποπίνακα

        // Prefix sum 2D για O(1) υπολογισμό κάθε υποπίνακα
        int[,] prefix = new int[rows + 1, cols + 1];

        for (int i = 1; i <= rows; i++)
            for (int j = 1; j <= cols; j++)
                prefix[i, j] = matrix[i - 1, j - 1]
                              + prefix[i - 1, j]
                              + prefix[i, j - 1]
                              - prefix[i - 1, j - 1];

        int maxSum = int.MinValue;
        int maxRow = 0, maxCol = 0;

        for (int i = subRows; i <= rows; i++)
        {
            for (int j = subCols; j <= cols; j++)
            {
                // Άθροισμα υποπίνακα που τελειώνει στο (i, j)
                int sum = prefix[i, j]
                        - prefix[i - subRows, j]
                        - prefix[i, j - subCols]
                        + prefix[i - subRows, j - subCols];

                Console.WriteLine($"Υποπίνακας [{i - subRows},{j - subCols}] -> [{i - 1},{j - 1}]: sum = {sum}");

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = i - subRows;
                    maxCol = j - subCols;
                }
            }
        }

        Console.WriteLine($"\n✅ Max Sum = {maxSum}");
        Console.WriteLine($"📍 Θέση: γραμμή {maxRow}, στήλη {maxCol}");
    }
}