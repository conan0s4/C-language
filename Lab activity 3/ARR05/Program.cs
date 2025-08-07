using System;

class RangeAudit
{
    static void Main()
    {
        int[] batchNums = new int[10];
        int tallyEven = 0;
        int tallyOdd = 0;
        int countDiv5 = 0;
        int track = 0;

        while (track < 10)
        {
            Console.Write($"drop num {track + 1}: ");
            string zap = Console.ReadLine();
            if (int.TryParse(zap, out int valPlug))
            {
                batchNums[track] = valPlug;

                if (valPlug % 2 == 0)
                    tallyEven++;
                else
                    tallyOdd++;

                if (valPlug % 5 == 0)
                    countDiv5++;

                track++;
            }
            else
            {
                Console.WriteLine("nah that ain't a number");
            }
        }

        Console.WriteLine($"even nums: {tallyEven}");
        Console.WriteLine($"odd nums: {tallyOdd}");
        Console.WriteLine($"div by 5: {countDiv5}");
    }
}
