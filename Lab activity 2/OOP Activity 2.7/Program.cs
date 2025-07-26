using System;

class MatrixDiagonalDifference
{
    static void Main()
    {
        int n;

        // Ask for matrix size (N >= 3)
        do
        {
            Console.Write("Enter the size of the matrix (N >= 3): ");
            n = int.Parse(Console.ReadLine());

            if (n < 3)
                Console.WriteLine("❌ N must be at least 3.");
        }
        while (n < 3);

        int[,] matrix = new int[n, n];

        // Input matrix values
        Console.WriteLine("\nEnter the elements of the matrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("Element [" + i + "," + j + "]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int leftToRightSum = 0;
        int rightToLeftSum = 0;

        for (int i = 0; i < n; i++)
        {
            leftToRightSum += matrix[i, i];             // Top-left to bottom-right
            rightToLeftSum += matrix[i, n - 1 - i];      // Top-right to bottom-left
        }

        int diff = Math.Abs(leftToRightSum - rightToLeftSum);

        Console.WriteLine("\nLeft-to-Right Diagonal Sum: " + leftToRightSum);
        Console.WriteLine("Right-to-Left Diagonal Sum: " + rightToLeftSum);
        Console.WriteLine("Absolute Diagonal Difference: " + diff);
    }
}
