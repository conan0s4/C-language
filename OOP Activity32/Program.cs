using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a capital letter (A–Z): ");
        string input = Console.ReadLine();

        // Validate single character and uppercase A-Z
        if (input.Length == 1 && input[0] >= 'A' && input[0] <= 'Z') // Check if input is a single capital letter
        {
            char endLetter = input[0]; // Convert input to char

            for (char row = 'A'; row <= endLetter; row++) // Loop through rows from A to the input letter
            {  // Loop through columns from A to the current row letter
                for (char col = 'A'; col <= row; col++) 
                {
                    Console.Write(col);// Print the current column letter
                }
                Console.WriteLine(); // Move to the next line after printing a row
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
