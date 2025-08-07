using System;

class Sorty14
{
    static void Main()
    {
        string[] nametag = new string[5];
        int[][] scorebox = new int[5][];
        int[] gradeSum = new int[5];
        int[] placelist = new int[5];

        for (int pupil = 0; pupil < 5; pupil++)
        {
            scorebox[pupil] = new int[3];
            Console.Write($"Enter name for student #{pupil + 1}: ");
            nametag[pupil] = Console.ReadLine();
            for (int topic = 0; topic < 3; topic++)
            {
                int entry = -1;
                while (entry < 0 || entry > 100)
                {
                    Console.Write($"Enter grade {topic + 1} for {nametag[pupil]}: ");
                    int.TryParse(Console.ReadLine(), out entry);
                }
                scorebox[pupil][topic] = entry;
                gradeSum[pupil] += entry;
            }
        }

        int[] indexBox = { 0, 1, 2, 3, 4 };
        Array.Sort(gradeSum, indexBox);
        Array.Reverse(gradeSum);
        Array.Reverse(indexBox);

        int[] reverseOrder = new int[5];
        for (int i = 0; i < 5; i++)
            reverseOrder[indexBox[i]] = i + 1;

        Console.WriteLine("\n== Final Standings ==");
        for (int i = 0; i < 5; i++)
            Console.WriteLine($"{nametag[i]} | Total: {scorebox[i][0] + scorebox[i][1] + scorebox[i][2]} | Rank: {reverseOrder[i]}");
    }
}
