using System;
using System.Collections.Generic;

class SlidingWindowSum
{
    static void Main()
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter at least 10 integers:");
        while (numbers.Count < 10)
        {
            Console.Write($"Number {numbers.Count + 1}: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                numbers.Add(num);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an integer.");
            }
        }

        Console.Write("\nEnter sliding window size (k): ");
        int k;
        while (!int.TryParse(Console.ReadLine(), out k) || k > numbers.Count || k <= 0)
        {
            Console.WriteLine($"Invalid. Enter a number between 1 and {numbers.Count}: ");
        }

        Console.WriteLine($"\nSliding window sums (size {k}):");
        for (int i = 0; i <= numbers.Count - k; i++)
        {
            int sum = 0;
            for (int j = i; j < i + k; j++)
            {
                sum += numbers[j];
            }
            Console.WriteLine($"Window {i + 1}: Sum = {sum}");
        }
    }
}
