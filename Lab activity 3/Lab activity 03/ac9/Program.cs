using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> stashNames = new List<string>();
        for (int loopName = 0; loopName < 6; loopName++)
        {
            Console.Write("name pls: ");
            string rawName = Console.ReadLine();
            string[] partsName = rawName.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int fixy = 0; fixy < partsName.Length; fixy++)
            {
                string chunk = partsName[fixy];
                if (chunk.Length > 0)
                {
                    partsName[fixy] = chunk.Substring(0, 1).ToUpper() + chunk.Substring(1).ToLower();
                }
            }
            stashNames.Add(string.Join(" ", partsName));
        }

        Console.WriteLine("\nformatted list:");
        foreach (string n in stashNames)
        {
            Console.WriteLine(n);
        }
    }
}
