using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listNamer = new List<string>();
        while (true)
        {
            Console.Write("Enter name (type 'done' to finish): ");
            string rawName = Console.ReadLine();
            if (rawName.Equals("done", StringComparison.OrdinalIgnoreCase))
                break;
            listNamer.Add(rawName);
        }

        List<string> upperNamer = new List<string>();
        foreach (var x in listNamer)
            upperNamer.Add(x.ToUpper());

        Console.WriteLine("\nNames in uppercase:");
        foreach (var y in upperNamer)
            Console.WriteLine(y);

        int aHeadCount = 0;
        foreach (var y in upperNamer)
            if (y.StartsWith("A"))
                aHeadCount++;

        Console.WriteLine($"\nCount starting with 'A': {aHeadCount}");
    }
}
