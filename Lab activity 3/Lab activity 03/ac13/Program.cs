using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> boxNames = new List<string>();
        List<int> boxScores = new List<int>();

        for (int grabber = 0; grabber < 10; grabber++)
        {
            Console.Write("name pls: ");
            string tempNom = Console.ReadLine();
            Console.Write("score pls: ");
            int tempPoints = int.Parse(Console.ReadLine());

            boxNames.Add(tempNom);
            boxScores.Add(tempPoints);
        }

        List<(string, int)> mergeBox = new List<(string, int)>();
        for (int i = 0; i < boxNames.Count; i++)
        {
            mergeBox.Add((boxNames[i], boxScores[i]));
        }

        mergeBox.Sort((a, b) => b.Item2.CompareTo(a.Item2));

        Console.WriteLine("\ntop 3:");
        for (int i = 0; i < 3 && i < mergeBox.Count; i++)
        {
            Console.WriteLine($"{mergeBox[i].Item1} - {mergeBox[i].Item2}");
        }
    }
}
