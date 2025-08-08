using System;
using System.Collections.Generic;

class LetterGradeSummary
{
    static void Main()
    {
        List<int> stashNums = new List<int>();
        int markA = 0, markB = 0, markC = 0, markD = 0, markF = 0;
        int countEntries = 0;

        while (countEntries < 10)
        {
            Console.Write("put grade num here: ");
            string snagTxt = Console.ReadLine();
            if (int.TryParse(snagTxt, out int grabNum) && grabNum >= 0 && grabNum <= 100)
            {
                stashNums.Add(grabNum);
                switch (grabNum / 10)
                {
                    case 10:
                    case 9:
                        markA++;
                        break;
                    case 8:
                        markB++;
                        break;
                    case 7:
                        markC++;
                        break;
                    case 6:
                        markD++;
                        break;
                    default:
                        markF++;
                        break;
                }
                countEntries++;
            }
            else
            {
                Console.WriteLine("nah thats not right");
            }
        }

        Console.WriteLine($"\nA: {markA}\nB: {markB}\nC: {markC}\nD: {markD}\nF: {markF}");
        Console.WriteLine("all grades:");
        foreach (var oneNum in stashNums)
        {
            Console.WriteLine(oneNum);
        }
    }
}
