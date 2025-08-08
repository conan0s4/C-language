using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> boxItems = new List<string>();
        for (int grab = 0; grab < 8; grab++)
        {
            Console.Write("Enter product name: ");
            boxItems.Add(Console.ReadLine());
        }

        Console.Write("Enter search keyword: ");
        string findWord = Console.ReadLine().ToLower();

        List<string> foundStuff = new List<string>();
        foreach (var single in boxItems)
        {
            if (single.ToLower().Contains(findWord))
            {
                foundStuff.Add(single);
            }
        }

        if (foundStuff.Count == 0)
        {
            Console.WriteLine("No products found.");
        }
        else
        {
            Console.WriteLine("Matching products:");
            foreach (var one in foundStuff)
            {
                Console.WriteLine(one);
            }
        }
    }
}
