using System;
using System.Collections.Generic;

class BirthYearAgeChecker
{
    static void Main()
    {
        List<string> bYearList = new List<string>();
        int loopIndex = 0;
        while (loopIndex < 5)
        {
            Console.Write($"birth year #{loopIndex + 1}: ");
            string rawYear = Console.ReadLine();
            int convertedYear;
            if (int.TryParse(rawYear, out convertedYear))
            {
                bYearList.Add(rawYear);
                loopIndex++;
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }

        int nowYr = DateTime.Now.Year;
        foreach (string txtYr in bYearList)
        {
            int yrNum = Convert.ToInt32(txtYr);
            int calcAge = nowYr - yrNum;
            string status;
            if (calcAge < 18)
                status = "Minor";
            else if (calcAge < 60)
                status = "Adult";
            else
                status = "Senior";

            Console.WriteLine($"{yrNum} -> {calcAge} yrs old ({status})");
        }
    }
}
