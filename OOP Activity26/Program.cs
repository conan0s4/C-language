using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        int maxLength = 0;
        int currentLength = 0;

        
        for (int i = 0; i < sentence.Length; i++) // Iterate through each character in the sentence
        {
            if (sentence[i] != ' ') // Check if the character is not a space
            { 
                currentLength++; // Increment the length of the current word
            }
            else
            {
                if (currentLength > maxLength) // If the current word's length is greater than the max found so far
                {
                    maxLength = currentLength; // Update the max length
                }
                currentLength = 0; // reset for next word
            }
        }

        // Handle last word (if no space at the end)
        if (currentLength > maxLength)// Check if the last word is the longest
        {
            maxLength = currentLength;// Update the max length if needed
        }
        // Output the result
        Console.WriteLine("Length of the longest word: " + maxLength);
    }
}

