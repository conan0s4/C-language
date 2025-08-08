using System;
using System.Collections.Generic;

class ProgVwlSwap
{
    static void Main()
    {
        List<string> origWords = new List<string>();
        List<string> changedWords = new List<string>();

        Console.Write("how many words: ");
        if (!int.TryParse(Console.ReadLine(), out int wordAmt) || wordAmt < 1)
            return;

        for (int i = 0; i < wordAmt; i++)
        {
            Console.Write($"word {i + 1}: ");
            string wInput = Console.ReadLine();
            origWords.Add(wInput);

            string altered = "";
            foreach (char ch in wInput)
            {
                if ("aeiouAEIOU".Contains(ch))
                    altered += "*";
                else
                    altered += ch;
            }
            changedWords.Add(altered);
        }

        Console.WriteLine("\norig   |   swapped");
        for (int i = 0; i < origWords.Count; i++)
            Console.WriteLine($"{origWords[i]}   |   {changedWords[i]}");
    }
}
