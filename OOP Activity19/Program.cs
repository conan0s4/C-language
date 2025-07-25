using System;

class Program
{
    static void Main()
    {
        string secretWord = "open";
        string guess;

        do
        {
            Console.Write("Guess the secret word: ");
            guess = Console.ReadLine();
            // check first 
            // if guess is not equals to secretWord, print "Try again."
            // syntax .equals / ordinalIgnoreCase
            if (!string.Equals(guess, secretWord, StringComparison.OrdinalIgnoreCase))
            { //source: https://learn.microsoft.com/en-us/dotnet/api/system.stringcomparer.ordinalignorecase?view=net-9.0
                Console.WriteLine("Try again.");
            }

        } while (!string.Equals(guess, secretWord, StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Correct!");
    }
}
