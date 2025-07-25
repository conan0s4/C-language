using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        string input = Console.ReadLine();
        int number;

        // Validate input and ensure it's a positive integer
        if (int.TryParse(input, out number) && number > 0)
        {
            while (number >= 10) // Keep looping until it's a single-digit
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                number = sum; // Replace with new sum
            }
            // Output the digital root
            Console.WriteLine("Digital Root: " + number);
        }
        else
        {// Handle invalid input
            Console.WriteLine("Invalid input.");
        }
    }
}
