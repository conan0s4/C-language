using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int uppercaseCount = 0;
        // Count uppercase letters in the sentence
        for (int i = 0; i < sentence.Length; i++) //length of the sentence [char]
        {
            if (char.IsUpper(sentence[i])) // Check if the character is uppercase
            {// If it is uppercase, increment the count
                uppercaseCount++;
            }
        }
        // Output the total count of uppercase letters
        Console.WriteLine("Total uppercase letters: " + uppercaseCount);
    }
}
