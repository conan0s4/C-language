using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();
        bool isPalindrome = true; 

        int length = word.Length;

        for (int i = 0; i < length / 2; i++) // Check only half of the word
        {
            if (word[i] != word[length - 1 - i]) // Compare characters from start and end
            {
                isPalindrome = false; // If any characters don't match, it's not a palindrome
                break;
            }
        }

        if (isPalindrome) // If all characters matched, it's a palindrome
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}

