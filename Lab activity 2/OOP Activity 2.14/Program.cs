using System;
using System.Collections.Generic;

class ZipCodeFrequencyCounter
{
    static void Main()
    {
        List<string> zipCodes = new List<string>();

        Console.WriteLine("Enter 25 zip codes:");
        for (int i = 0; i < 25; i++)
        {
            Console.Write($"Zip Code {i + 1}: ");
            string zip = Console.ReadLine();
            zipCodes.Add(zip);
        }

        // Count frequencies
        Dictionary<string, int> frequency = new Dictionary<string, int>();
        foreach (string zip in zipCodes)
        {
            if (frequency.ContainsKey(zip))
            {
                frequency[zip]++;
            }
            else
            {
                frequency[zip] = 1;
            }
        }

        // Sort by frequency (descending)
        List<KeyValuePair<string, int>> sorted = new List<KeyValuePair<string, int>>(frequency);
        sorted.Sort((a, b) => b.Value.CompareTo(a.Value));

        // Display result
        Console.WriteLine("\nZip Code  |  Frequency");
        Console.WriteLine("-----------------------");
        foreach (var pair in sorted)
        {
            Console.WriteLine($"{pair.Key,-10} |  {pair.Value}");
        }
    }
}
