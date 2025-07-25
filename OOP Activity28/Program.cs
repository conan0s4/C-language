using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        // Check if the input is not null or empty
        if (!string.IsNullOrEmpty(word)) 
        {
            Console.Write("Reversed word: ");// Print the reversed word
            for (int i = word.Length - 1; i >= 0; i--)// Loop through the word in reverse order
            {
                Console.Write(word[i]);// Print each character
            }
            Console.WriteLine();// Print a new line after the reversed word
        }
        else
        { // If the input is null or empty, print an error message
            Console.WriteLine("Invalid input.");
        }
    }
}
