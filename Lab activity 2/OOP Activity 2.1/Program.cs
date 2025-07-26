using System;

class StudentRankTracker
{
    static void Main()
    {
        string[] names = new string[10];
        int[] scores = new int[10];

        // Input: 10 student names and scores
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter name of student " + (i + 1) + ": ");  
            names[i] = Console.ReadLine();

            Console.Write("Enter score of " + names[i] + ": ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        // Simple bubble sort (descending by score, ascending by name if scores are equal)
        for (int i = 0; i < 9; i++)
        {
            for (int j = i + 1; j < 10; j++)
            {
                if (scores[i] < scores[j] ||
                   (scores[i] == scores[j] && string.Compare(names[i], names[j]) > 0))
                {
                    // Swap scores
                    int tempScore = scores[i];
                    scores[i] = scores[j];
                    scores[j] = tempScore;

                    // Swap names
                    string tempName = names[i];
                    names[i] = names[j];
                    names[j] = tempName;
                }
            }
        }

        // Output: Top 3 students
        Console.WriteLine("\nTop 3 Students:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Rank " + (i + 1) + ": " + names[i] + " (Score: " + scores[i] + ")");
        }
    }
}
