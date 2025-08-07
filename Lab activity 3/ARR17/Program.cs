using System;

class NumbLab17
{
    static void Main()
    {
        int totalNums = 8;
        int[] stash = new int[totalNums];

        for (int grab = 0; grab < totalNums; grab++)
        {
            Console.Write($"drop num {grab + 1}: ");
            while (!int.TryParse(Console.ReadLine(), out stash[grab]) || stash[grab] < 0)
            {
                Console.Write("nah, whole nums only: ");
            }
        }

        Console.WriteLine("\nreport starts now\n");

        foreach (int slice in stash)
        {
            bool primeCheck = true;
            if (slice < 2) primeCheck = false;
            else
            {
                for (int test = 2; test * test <= slice; test++)
                {
                    if (slice % test == 0)
                    {
                        primeCheck = false;
                        break;
                    }
                }
            }

            string binver = Convert.ToString(slice, 2);
            string evenOdd = (slice % 2 == 0) ? "even" : "odd";
            string primeTag = primeCheck ? "prime" : "not prime";

            Console.WriteLine($"num: {slice} → {primeTag}, bin: {binver}, {evenOdd}");
        }
    }
}
