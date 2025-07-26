using System;

class ContactDeduplicator
{
    static void Main()
    {
        string[] inputNames = new string[15];
        string[] uniqueNames = new string[15];
        int uniqueCount = 0;

        Console.WriteLine("Enter 15 contact names (duplicates allowed):");
        for (int i = 0; i < 15; i++)
        {
            Console.Write("Name " + (i + 1) + ": ");
            string name = Console.ReadLine();
            inputNames[i] = name;
        }

        // Remove duplicates (case-insensitive)
        for (int i = 0; i < 15; i++)
        {
            bool isDuplicate = false;
            string currentName = inputNames[i].ToLower();

            for (int j = 0; j < uniqueCount; j++)
            {
                if (currentName == uniqueNames[j].ToLower())
                {
                    isDuplicate = true;
                    break;
                }
            }

            if (!isDuplicate)
            {
                uniqueNames[uniqueCount] = inputNames[i];
                uniqueCount++;
            }
        }

        // Sort unique names alphabetically (simple bubble sort)
        for (int i = 0; i < uniqueCount - 1; i++)
        {
            for (int j = i + 1; j < uniqueCount; j++)
            {
                if (string.Compare(uniqueNames[i], uniqueNames[j], StringComparison.OrdinalIgnoreCase) > 0)
                {
                    // Swap
                    string temp = uniqueNames[i];
                    uniqueNames[i] = uniqueNames[j];
                    uniqueNames[j] = temp;
                }
            }
        }

        // Output
        Console.WriteLine("\n📇 Unique, Sorted Contact Names:");
        for (int i = 0; i < uniqueCount; i++)
        {
            Console.WriteLine(uniqueNames[i]);
        }
    }
}

