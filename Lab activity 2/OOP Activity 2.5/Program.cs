using System;

class CircularShifter
{
    static void Main()
    {
        int[] original = new int[10];
        int[] shifted = new int[10];

        // Input: 10 integers
        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Element " + (i + 1) + ": ");
            original[i] = int.Parse(Console.ReadLine());
        }

        // Input: value of k
        Console.Write("Enter value of k (number of right shifts): ");
        int k = int.Parse(Console.ReadLine());

        // Ensure k is within array length
        k = k % 10;

        // Perform circular shift
        for (int i = 0; i < 10; i++)
        {
            int newIndex = (i + k) % 10;
            shifted[newIndex] = original[i];
        }

        // Output: original array
        Console.WriteLine("\nOriginal Array:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(original[i] + " ");
        }

        // Output: shifted array
        Console.WriteLine("\nShifted Array (Right by " + k + "):");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(shifted[i] + " ");
        }

        Console.WriteLine();
    }
}
