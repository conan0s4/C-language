using System;

class SnagSaleLogger
{
    static void Main()
    {
        float[] cashSpots = new float[12];
        string[] monthLabels = {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
        };

        float totalVault = 0;
        int blasterTop = 0;
        int crashDrop = 0;

        for (int tag = 0; tag < 12; tag++)
        {
            Console.Write($"Sales for {monthLabels[tag]}: ");
            while (!float.TryParse(Console.ReadLine(), out cashSpots[tag]))
            {
                Console.Write("Invalid. Try again: ");
            }

            if (cashSpots[tag] > cashSpots[blasterTop]) blasterTop = tag;
            if (cashSpots[tag] < cashSpots[crashDrop]) crashDrop = tag;

            totalVault += cashSpots[tag];
        }

        float avgFlow = totalVault / 12f;

        Console.WriteLine($"\nPeak Month: {monthLabels[blasterTop]} (${cashSpots[blasterTop]})");
        Console.WriteLine($"Lowest Month: {monthLabels[crashDrop]} (${cashSpots[crashDrop]})");
        Console.WriteLine($"Average Monthly Sales: ${avgFlow:F2}");
    }
}
