using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1–10): ");
        string input = Console.ReadLine();
        int number;

        // Validate input: must be an integer between 1 and 10
        if (int.TryParse(input, out number) && number >= 1 && number <= 10)
        {
            Console.WriteLine($"\nMultiplication table for {number}:\n");
            // Print the multiplication table
            for (int i = 1; i <= 10; i++)
            {   //num user stated * times i++ increment from 1 to 10 = result
                Console.WriteLine($"{number} x {i} = {number * i}");
            }
        }
        else
        {  // If input is invalid, inform the user
            Console.WriteLine("Invalid input.");
        }
    }
}
