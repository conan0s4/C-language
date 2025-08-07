using System;

class Program
{
    static void Main()
    {
        string[] identityTag = new string[10];
        int[] yearsOld = new int[10];
        string[] voterLevel = new string[10];
        int peopleCount = 0;

        while (peopleCount < 10)
        {
            Console.Write($"Enter name for citizen #{peopleCount + 1}: ");
            string whoDis = Console.ReadLine();

            Console.Write($"Enter age for {whoDis}: ");
            string ageStuff = Console.ReadLine();

            bool ageOk = int.TryParse(ageStuff, out int ageVal);

            if (!ageOk || ageVal < 0 || ageVal > 120)
            {
                Console.WriteLine("Invalid age. Try again.");
                continue;
            }

            identityTag[peopleCount] = whoDis;
            yearsOld[peopleCount] = ageVal;

            if (ageVal < 18)
            {
                voterLevel[peopleCount] = "Not eligible to vote";
            }
            else if (ageVal <= 30)
            {
                voterLevel[peopleCount] = "Young Voter";
            }
            else if (ageVal <= 59)
            {
                voterLevel[peopleCount] = "Mid-age Voter";
            }
            else
            {
                voterLevel[peopleCount] = "Senior Voter";
            }

            peopleCount++;
        }

        Console.WriteLine("\n=== Voter Info Summary ===");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Name: {identityTag[i]} | Age: {yearsOld[i]} | Status: {voterLevel[i]}");
        }
    }
}
