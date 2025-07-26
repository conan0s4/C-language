using System;

class LeaderboardUpdater
{
    static void Main()
    {
        int[] scores = new int[11]; // Max 11 after inserting new score
        int count = 10;

        Console.WriteLine("Enter 10 player scores:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Score {i + 1}: ");
            scores[i] = int.Parse(Console.ReadLine());
        }

        // Sort the initial scores in descending order
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (scores[i] < scores[j])
                {
                    int temp = scores[i];
                    scores[i] = scores[j];
                    scores[j] = temp;
                }
            }
        }

        Console.WriteLine("\nInitial Leaderboard:");
        PrintLeaderboard(scores, count);

        // Get the new score
        Console.Write("\nEnter new player's score: ");
        int newScore = int.Parse(Console.ReadLine());

        // Find the correct position
        int pos = count;
        for (int i = 0; i < count; i++)
        {
            if (newScore > scores[i])
            {
                pos = i;
                break;
            }
        }

        // Shift scores to make room
        for (int i = count; i > pos; i--)
        {
            scores[i] = scores[i - 1];
        }

        // Insert new score
        scores[pos] = newScore;
        count++;

        Console.WriteLine("\nUpdated Leaderboard:");
        PrintLeaderboard(scores, count);
    }

    static void PrintLeaderboard(int[] scores, int length)
    {
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"{i + 1}. {scores[i]}");
        }
    }
}
