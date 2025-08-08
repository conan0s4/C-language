using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> bucketCourses = new List<string>();
        while (bucketCourses.Count < 6)
        {
            Console.Write("Type course code: ");
            string grabCode = Console.ReadLine();

            if (grabCode.Length != 5)
            {
                Console.WriteLine("Invalid length");
                continue;
            }
            if (bucketCourses.Contains(grabCode))
            {
                Console.WriteLine("Duplicate course");
                continue;
            }

            bucketCourses.Add(grabCode);
            Console.WriteLine("Added: " + grabCode);
        }

        Console.WriteLine("\nAll valid courses:");
        foreach (string course in bucketCourses)
        {
            Console.WriteLine(course);
        }
    }
}
