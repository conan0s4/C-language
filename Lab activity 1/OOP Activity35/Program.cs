using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string input = Console.ReadLine();
        string result = "";

        bool newWord = true;

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (c == ' ')
            {
                result += c;
                newWord = true;
            }
            else
            {
                if (newWord)
                {
                    result += Char.ToUpper(c);
                    newWord = false;
                }
                else
                {
                    result += Char.ToLower(c);
                }
            }
        }

        Console.WriteLine("Formatted: " + result);
    }
}




