using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number to start countdown: ");
        string input = Console.ReadLine();
        int number;

        // Validate input: must be an integer > 0
        if (int.TryParse(input, out number) && number > 0)
        {
            Console.WriteLine("\nCountdown:");
            while (number >= 0) //don't stop until it reaches 0
            {
                Console.WriteLine(number); // print the current number
                number--; // decrement the number by 1
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}

