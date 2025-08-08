using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> stashCities = new List<string>();
        while (true)
        {
            Console.Write("city name (exit to stop): ");
            string grabName = Console.ReadLine();
            if (grabName.Trim().ToLower() == "exit")
                break;
            if (!string.IsNullOrWhiteSpace(grabName))
                stashCities.Add(grabName);
        }

        List<string> tidyList = stashCities.Distinct().ToList();
        tidyList.Sort();

        Console.WriteLine("\ncity list:");
        foreach (string c in tidyList)
            Console.WriteLine(c);
    }
}
