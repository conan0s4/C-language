using System;

class FruitTallyRunner
{
    static void Main()
    {
        string[] stashOfFruits = new string[5];
        int appleSightings = 0;

        for (int n = 0; n < stashOfFruits.Length; n++)
        {
            Console.Write("drop fav fruit " + (n + 1) + ": ");
            string rawInput = Console.ReadLine();
            string cleanedInput = rawInput.ToLower();
            stashOfFruits[n] = cleanedInput;

            if (cleanedInput == "apple")
            {
                appleSightings++;
            }
        }

        Console.WriteLine("apple showed up " + appleSightings + " times");
    }
}

