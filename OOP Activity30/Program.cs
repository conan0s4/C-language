using System;

class Program
{
    public void ConvertNumberToWords() 
    {
        Console.Write("Enter a number (0–999): ");
        string input = Console.ReadLine();
        int number;

        // Validate input and convert to number
        if (int.TryParse(input, out number) && number >= 0 && number <= 999)
        {
            string words = ""; // Initialize an empty string for the words

            if (number == 0) // Special case for zero
            {
                words = "Zero";
            }
            else
            {  // Process the number to convert it to words
                int hundreds = number / 100; // Get the hundreds place
                int tensOnes = number % 100; // Get the tens and ones places
                int tens = tensOnes / 10; // Get the tens place
                int ones = tensOnes % 10; // Get the ones place

                if (hundreds > 0) // Check if there are hundreds
                {
                    words += GetDigitWord(hundreds) + " Hundred"; // Add hundreds word
                    if (tensOnes > 0) // If there are tens or ones, add a space
                    {
                        words += " ";
                    }
                }
                // Check if the tens and ones together form a number from 10 to 19
                if (tensOnes >= 10 && tensOnes <= 19) 
                {   
                    words += GetTeenWord(tensOnes); 
                }
                else
                {
                    if (tens > 1)
                    {
                        words += GetTensWord(tens);
                        if (ones > 0)
                        {
                            words += " " + GetDigitWord(ones);
                        }
                    }
                    else if (ones > 0)
                    {
                        words += GetDigitWord(ones);
                    }
                }
            }

            Console.WriteLine("In words: " + words);
        }
        else
        {
            Console.WriteLine("Invalid input. Enter a number from 0 to 999.");
        }
    }

    string GetDigitWord(int num) // Helper method to get the word for a single digit
    {
        switch (num) 
        {
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            default: return "";
        }
    }

    string GetTensWord(int num) // Helper method to get the word for tens (20, 30, ..., 90)
    {
        switch (num)
        {
            case 2: return "Twenty";
            case 3: return "Thirty";
            case 4: return "Forty";
            case 5: return "Fifty";
            case 6: return "Sixty";
            case 7: return "Seventy";
            case 8: return "Eighty";
            case 9: return "Ninety";
            default: return "";
        }
    }

    string GetTeenWord(int num) // Helper method to get the word for numbers from 10 to 19
    {
        switch (num)
        {
            case 10: return "Ten";
            case 11: return "Eleven";
            case 12: return "Twelve";
            case 13: return "Thirteen";
            case 14: return "Fourteen";
            case 15: return "Fifteen";
            case 16: return "Sixteen";
            case 17: return "Seventeen";
            case 18: return "Eighteen";
            case 19: return "Nineteen";
            default: return "";
        }
    }

    static void Main() // Main method to run the program
    {
        Program p = new Program(); //   Create an instance of the Program class
        p.ConvertNumberToWords(); // Call the method to convert number to words
    }
}
