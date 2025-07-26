using System;

class SurveyAnalyzer
{
    static void Main()
    {
        int[] ages = new int[20];
        int total = 0;
        int min = int.MaxValue;
        int max = int.MinValue;

        // Bracket counters
        int under18 = 0;
        int between18_35 = 0;
        int between36_60 = 0;
        int over60 = 0;

        // Input: 20 ages
        for (int i = 0; i < 20; i++)
        {
            Console.Write("Enter age for person " + (i + 1) + ": ");
            int age = int.Parse(Console.ReadLine());
            ages[i] = age;
            total += age;

            if (age < min) min = age;
            if (age > max) max = age;

            // Count brackets
            if (age < 18) under18++;
            else if (age <= 35) between18_35++;
            else if (age <= 60) between36_60++;
            else over60++;
        }

        double average = total / 20.0;

        // Output: formatted table
        Console.WriteLine("\n--- Survey Results ---");
        Console.WriteLine("Average Age : " + average);
        Console.WriteLine("Minimum Age : " + min);
        Console.WriteLine("Maximum Age : " + max);

        Console.WriteLine("\nAge Bracket       | Count");
        Console.WriteLine("------------------|-------");
        Console.WriteLine("< 18              | " + under18);
        Console.WriteLine("18 - 35           | " + between18_35);
        Console.WriteLine("36 - 60           | " + between36_60);
        Console.WriteLine("> 60              | " + over60);
    }
}

