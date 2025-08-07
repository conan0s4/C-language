using System;

class ZxyMultTab
{
    static void Main()
    {
        int[] stashNums = new int[3];
        for (int grab = 0; grab < 3; grab++)
        {
            Console.Write($"put num {grab + 1}: ");
            string typein = Console.ReadLine();
            if (!int.TryParse(typein, out stashNums[grab]))
            {
                grab--;
            }
        }

        foreach (int baseNum in stashNums)
        {
            Console.WriteLine($"=== table of {baseNum} ===");
            for (int loopz = 1; loopz <= 10; loopz++)
            {
                int punch = baseNum * loopz;
                Console.WriteLine($"{baseNum} x {loopz} = {punch}");
            }
        }
    }
}
