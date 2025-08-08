using System;
using System.Collections.Generic;

class AttendTrack
{
    static void Main()
    {
        List<string> regNames = new List<string>();
        while (true)
        {
            Console.Write("enter name (blank = stop): ");
            string gotName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(gotName)) break;
            if (!regNames.Contains(gotName))
            {
                regNames.Add(gotName);
            }
        }
        regNames.Sort();
        Console.WriteLine("total unique: " + regNames.Count);
        foreach (var single in regNames)
        {
            Console.WriteLine(single);
        }
    }
}
