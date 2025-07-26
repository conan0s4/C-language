using System;

class ArrayExpressionEvaluator
{
    static void Main()
    {
        int[] numbers = new int[10];
        int[] results = new int[10];

        Console.WriteLine("Enter 10 integers:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Number {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nApplying expression: (2 * x + 3) % 5");
        for (int i = 0; i < 10; i++)
        {
            results[i] = (2 * numbers[i] + 3) % 5;
        }

        Console.WriteLine("\nOriginal  ->  Evaluated");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{numbers[i],7}  ->  {results[i],9}");
        }
    }
}
