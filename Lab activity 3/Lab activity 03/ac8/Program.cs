using System;
using System.Collections.Generic;
using System.Linq;

class ProgRun
{
    static void Main()
    {
        List<int> boxAllNums = new List<int>();
        for (int ctrGrab = 0; ctrGrab < 10; ctrGrab++)
        {
            Console.Write("num pls: ");
            if (int.TryParse(Console.ReadLine(), out int tempVal))
            {
                boxAllNums.Add(tempVal);
            }
            else
            {
                ctrGrab--;
            }
        }

        List<int> boxBigNums = boxAllNums.Where(a => a > 50).ToList();

        Console.WriteLine("og count: " + boxAllNums.Count);
        Console.WriteLine("big count: " + boxBigNums.Count);
    }
}
