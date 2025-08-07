using System;

class AgeSniffer
{
    static void Main()
    {
        int[] zetaScan = new int[5];
        int countLoop = 0;
        int tPhase = 0;

        while (countLoop < 5)
        {
            Console.Write("Drop age " + (countLoop + 1) + ": ");
            string rawDrop = Console.ReadLine();

            if (int.TryParse(rawDrop, out int parsedAge))
            {
                if (parsedAge >= 10 && parsedAge <= 99)
                {
                    zetaScan[countLoop] = parsedAge;
                    countLoop++;
                }
                else
                {
                    Console.WriteLine("nah that age don't fly. 10-99 only.");
                }
            }
            else
            {
                Console.WriteLine("yo that's not even a number.");
            }
        }

        Console.WriteLine("\nCollected intel:");
        foreach (int frame in zetaScan)
        {
            Console.WriteLine("-> " + frame);
            if (frame >= 13 && frame <= 19)
            {
                tPhase++;
            }
        }

        Console.WriteLine("\nTeenager count: " + tPhase);
    }
}
