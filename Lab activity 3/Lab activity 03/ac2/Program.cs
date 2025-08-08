using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<decimal> stashPrices = new List<decimal>();
        while (true)
        {
            Console.Write("item price (-1 to stop): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal grabPrice))
                continue;
            if (grabPrice == -1)
                break;
            if (grabPrice < 0)
                continue;
            stashPrices.Add(grabPrice);
        }

        if (stashPrices.Count > 0)
        {
            Console.WriteLine("total items: " + stashPrices.Count);
            Console.WriteLine("average: " + stashPrices.Average());
            Console.WriteLine("highest: " + stashPrices.Max());
            Console.WriteLine("lowest: " + stashPrices.Min());
        }
        else
        {
            Console.WriteLine("no items");
        }
    }
}
