using System;
using System.Collections.Generic;

class WordAnalyzerProg
{
    static void Main()
    {
        List<string> stashWords = new List<string>();
        for (int entryNum = 0; entryNum < 5; entryNum++)
        {
            Console.Write("Sentence " + (entryNum + 1) + ": ");
            string givenLine = Console.ReadLine();
            string[] sliceParts = givenLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string w in sliceParts)
            {
                string lowered = w.ToLower();
                if (!stashWords.Contains(lowered))
                {
                    stashWords.Add(lowered);
                }
            }
        }
        stashWords.Sort();
        Console.WriteLine("Unique word count: " + stashWords.Count);
        foreach (string piece in stashWords)
        {
            Console.WriteLine(piece);
        }
    }
}
