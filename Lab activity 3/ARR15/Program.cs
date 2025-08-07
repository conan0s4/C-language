using System;

class LuckyDrawRun
{
    static void Main()
    {
        int[] pickStorage = new int[20];
        int[] jackpotDigits = { 5, 12, 23, 34, 45, 56, 67, 78, 89 };
        int counterClicks = 0;

        while (counterClicks < 20)
        {
            Console.Write("Enter lucky number (1-99): ");
            string userTyped = Console.ReadLine();
            bool legit = int.TryParse(userTyped, out int parsedPick);

            if (!legit || parsedPick < 1 || parsedPick > 99)
            {
                Console.WriteLine("Invalid. Try again.");
                continue;
            }

            pickStorage[counterClicks] = parsedPick;
            counterClicks++;
        }

        Console.WriteLine("\n--- Result Zone ---");
        for (int j = 0; j < pickStorage.Length; j++)
        {
            bool found = false;
            for (int k = 0; k < jackpotDigits.Length; k++)
            {
                if (pickStorage[j] == jackpotDigits[k])
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"User {j + 1}: {pickStorage[j]} - Congrats you won!");
            }
        }
    }
}
