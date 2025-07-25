using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string word = Console.ReadLine();

        Console.Write("Enter index position (starting from 0): ");
        string indexInput = Console.ReadLine();
        int index;

        if (int.TryParse(indexInput, out index))
        {
            if (index >= 0 && index < word.Length)
            {
                Console.WriteLine("Character at index " + index + ": " + word[index]);
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }
        }
        else
        {
            Console.WriteLine("Invalid index.");
        }
    }
}
