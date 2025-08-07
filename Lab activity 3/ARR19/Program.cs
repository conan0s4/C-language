using System;

class BudgetBreaker
{
    static void Main()
    {
        string[] tagList = { "food", "rent", "utilities", "transport", "others" };
        float[] coinDrop = new float[tagList.Length];
        float fullCash = 0f;
        float walletCap = 25000f;

        for (int n = 0; n < tagList.Length; n++)
        {
            Console.Write($"how much for {tagList[n]}: ");
            string toss = Console.ReadLine();
            float.TryParse(toss, out coinDrop[n]);
            fullCash += coinDrop[n];
        }

        Console.WriteLine($"total spent: {fullCash}");

        if (fullCash > walletCap)
        {
            float hugestSpend = coinDrop[0];
            int pickSpot = 0;

            for (int x = 1; x < coinDrop.Length; x++)
            {
                if (coinDrop[x] > hugestSpend)
                {
                    hugestSpend = coinDrop[x];
                    pickSpot = x;
                }
            }

            Console.WriteLine("yo you're over budget, maybe cut down on: " + tagList[pickSpot]);
        }
        else
        {
            Console.WriteLine("budget fits, no worries");
        }
    }
}
