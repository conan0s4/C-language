using System;

class PollDash
{
    static void Main()
    {
        string contenderUno = "mika";
        string contenderDos = "rex";
        string contenderTres = "jana";

        int buzzMika = 0, buzzRex = 0, buzzJana = 0;

        string[] pickBox = new string[10];

        for (int entryNo = 0; entryNo < 10; entryNo++)
        {
            Console.Write($"Vote #{entryNo + 1}: ");
            string inputVote = Console.ReadLine().Trim().ToLower();

            if (inputVote == contenderUno)
                buzzMika++;
            else if (inputVote == contenderDos)
                buzzRex++;
            else if (inputVote == contenderTres)
                buzzJana++;
        }

        Console.WriteLine($"\n{contenderUno} total: {buzzMika}");
        Console.WriteLine($"{contenderDos} total: {buzzRex}");
        Console.WriteLine($"{contenderTres} total: {buzzJana}");

        string winnerTag = "";
        int highBuzz = Math.Max(buzzMika, Math.Max(buzzRex, buzzJana));

        if (buzzMika == highBuzz)
            winnerTag = contenderUno;
        else if (buzzRex == highBuzz)
            winnerTag = contenderDos;
        else if (buzzJana == highBuzz)
            winnerTag = contenderTres;

        Console.WriteLine($"\nTop pick is: {winnerTag.ToUpper()} with {highBuzz} votes.");
    }
}
