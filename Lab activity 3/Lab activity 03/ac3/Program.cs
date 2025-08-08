using System;
using System.Collections.Generic;

class ProgRun
{
    static void Main()
    {
        List<string> stashNames = new List<string> { "Raven", "Maxwell", "Aiden", "Sophia", "Lara" };
        Console.Write("char to search: ");
        string grabChar = Console.ReadLine().ToLower();

        foreach (string pickName in stashNames)
        {
            if (pickName.ToLower().Contains(grabChar))
            {
                Console.WriteLine(pickName);
            }
        }
    }
}
