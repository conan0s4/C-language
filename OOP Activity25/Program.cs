using System;

class Program
{
    static void Main()
    {
        int total = 0;
        string input;

        while (true)
        {
            Console.Write("Enter a number (or type 'stop' to finish): ");
            input = Console.ReadLine();

            // Manually check for lowercase "stop"
            string lowerInput = input.ToLower();
            // Check if the input is "stop" in lowercase then stop
            if (lowerInput == "stop")
            {
                break;
            }

            int number;
            if (int.TryParse(input, out number)) // Try to parse the input as an integer
            {
                total += number; // Add the number to the total
            }
            else
            {
                // Invalid entry ignored
                continue;
            }
        }

        Console.WriteLine("Total sum: " + total);
    }
}


