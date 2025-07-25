using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        string input = Console.ReadLine();
        int rows;

        if (int.TryParse(input, out rows) && rows > 0) // Validate input    
        {
            int currentNumber = 1; // Start from 1

            for (int i = 1; i <= rows; i++) // Loop through each row
            {
                for (int j = 1; j <= i; j++)// Loop through each column in the current row
                {
                    Console.Write(currentNumber + " ");
                    currentNumber++;
                }
                Console.WriteLine(); // Move to next line
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}

