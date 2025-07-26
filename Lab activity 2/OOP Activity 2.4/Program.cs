using System;

class StockPriceTracker
{
    static void Main()
    {
        float[] prices = new float[7];
        float[] percentGain = new float[7];
        int highestGainDay = -1;
        float highestGain = float.MinValue;

        // Input: 7 stock prices
        for (int i = 0; i < 7; i++)
        {
            Console.Write("Enter stock price for Day " + (i + 1) + ": ");
            prices[i] = float.Parse(Console.ReadLine());
        }

        // Calculate percentage gains
        percentGain[0] = 0; // No gain for first day

        for (int i = 1; i < 7; i++)
        {
            if (prices[i - 1] != 0)
            {
                percentGain[i] = ((prices[i] - prices[i - 1]) / prices[i - 1]) * 100;

                if (percentGain[i] > highestGain)
                {
                    highestGain = percentGain[i];
                    highestGainDay = i;
                }
            }
            else
            {
                percentGain[i] = 0; // Avoid divide by zero
            }
        }

        // Output: percentage gain per day
        Console.WriteLine("\nDay\tPrice\tGain (%)");
        Console.WriteLine("-----------------------------");
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine("Day " + (i + 1) + "\t" + prices[i] + "\t" + percentGain[i].ToString("F2") + "%");
        }

        // Output: highest gain day
        if (highestGainDay != -1)
        {
            Console.WriteLine("\n📈 Highest gain was on Day " + (highestGainDay + 1) +
                              " with a gain of " + highestGain.ToString("F2") + "%.");
        }
        else
        {
            Console.WriteLine("\nNo gain recorded.");
        }
    }
}
