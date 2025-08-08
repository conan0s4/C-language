using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> pileOrig = new List<int>();
        List<int> stashEven = new List<int>();
        List<int> stashOdd = new List<int>();

        for (int counterZap = 0; counterZap < 12; counterZap++)
        {
            Console.Write("num pls: ");
            if (int.TryParse(Console.ReadLine(), out int grabNum))
            {
                pileOrig.Add(grabNum);
                if (grabNum % 2 == 0)
                    stashEven.Add(grabNum);
                else
                    stashOdd.Add(grabNum);
            }
            else
            {
                counterZap--;
            }
        }

        Console.WriteLine("\nEven ones:");
        foreach (var valX in stashEven)
            Console.Write(valX + " ");

        Console.WriteLine("\nOdd ones:");
        foreach (var valY in stashOdd)
            Console.Write(valY + " ");
    }
}
