using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> pplNamez = new List<string>();
        List<float> cashValz = new List<float>();

        Console.Write("how many peeps: ");
        int howMany = int.Parse(Console.ReadLine());

        for (int idx = 0; idx < howMany; idx++)
        {
            Console.Write("name: ");
            string tmpName = Console.ReadLine();
            Console.Write("salary: ");
            float tmpPay = float.Parse(Console.ReadLine());

            pplNamez.Add(tmpName);
            cashValz.Add(tmpPay);
        }

        for (int idx = 0; idx < cashValz.Count; idx++)
        {
            if (cashValz[idx] < 15000)
            {
                cashValz[idx] += cashValz[idx] * 0.05f;
            }
            else if (cashValz[idx] >= 15000 && cashValz[idx] <= 30000)
            {
                cashValz[idx] += cashValz[idx] * 0.03f;
            }
        }

        Console.WriteLine("\nAbove 25k earners after raise:");
        for (int idx = 0; idx < cashValz.Count; idx++)
        {
            if (cashValz[idx] > 25000)
            {
                Console.WriteLine($"{pplNamez[idx]} - {cashValz[idx]:F2}");
            }
        }
    }
}
