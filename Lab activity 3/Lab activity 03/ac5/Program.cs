using System;
using System.Collections.Generic;

class ProgGrdAna
{
    static void Main()
    {
        List<int> collMarkData = new List<int>();
        int totA = 0, totB = 0, totC = 0, totD = 0, totF = 0;

        while (collMarkData.Count < 7)
        {
            Console.Write("grade: ");
            string grabLine = Console.ReadLine();
            if (int.TryParse(grabLine, out int chkNum) && chkNum >= 0 && chkNum <= 100)
            {
                collMarkData.Add(chkNum);
            }
        }

        foreach (int g in collMarkData)
        {
            switch (g)
            {
                case int n when (n >= 90 && n <= 100):
                    totA++;
                    break;
                case int n when (n >= 80 && n <= 89):
                    totB++;
                    break;
                case int n when (n >= 70 && n <= 79):
                    totC++;
                    break;
                case int n when (n >= 60 && n <= 69):
                    totD++;
                    break;
                default:
                    totF++;
                    break;
            }
        }

        Console.WriteLine($"A: {totA}");
        Console.WriteLine($"B: {totB}");
        Console.WriteLine($"C: {totC}");
        Console.WriteLine($"D: {totD}");
        Console.WriteLine($"F: {totF}");
    }
}
