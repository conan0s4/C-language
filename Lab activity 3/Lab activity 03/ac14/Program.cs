using System;
using System.Collections.Generic;

class CapitalSpotter
{
    static void Main()
    {
        List<string> nationList = new List<string> { "Philippines", "Japan", "Spain", "Canada", "Brazil" };
        List<string> mainCityList = new List<string> { "Manila", "Tokyo", "Madrid", "Ottawa", "Brasilia" };

        Console.Write("Enter a country: ");
        string givenNation = Console.ReadLine().Trim().ToLower();

        bool gotIt = false;
        for (int slot = 0; slot < nationList.Count; slot++)
        {
            if (nationList[slot].ToLower() == givenNation)
            {
                Console.WriteLine($"Capital: {mainCityList[slot]}");
                gotIt = true;
                break;
            }
        }

        if (!gotIt)
        {
            Console.WriteLine("Country not found.");
        }
    }
}
