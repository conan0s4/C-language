using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        Console.Write("Convert to (upper/lower): ");
        string choice = Console.ReadLine();

        
        if (choice == "upper") // Check if the user wants to convert to uppercase 
        {   
            Console.WriteLine("Uppercase: " + sentence.ToUpper()); // Convert the sentence to uppercase
        }
        else if (choice == "lower") // Check if the user wants to convert to lowercase
        {
            Console.WriteLine("Lowercase: " + sentence.ToLower()); // Convert the sentence to lowercase
        }
        else
        { // If the user input is neither "upper" nor "lower" INVALID
            Console.WriteLine("Invalid choice.");
        }
    }
}
