using System;

class MirageScan
{
    static void Main()
    {
        string[] vaultWords = new string[5];
        for (int i = 0; i < vaultWords.Length; i++)
        {
            Console.Write($"drop word #{i + 1}: ");
            vaultWords[i] = Console.ReadLine();
        }

        foreach (string drift in vaultWords)
        {
            string flipped = "";
            for (int i = drift.Length - 1; i >= 0; i--)
                flipped += drift[i];

            if (string.Equals(drift, flipped, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine($"{drift} → Palindrome");
            else
                Console.WriteLine($"{drift} → Not a Palindrome");
        }
    }
}
