using System;

class GradeConvertRun
{
    static void Main()
    {
        float[] sneakyScores = new float[5];
        string[] gradeBox = new string[5];

        for (int pos = 0; pos < sneakyScores.Length; pos++)
        {
            Console.Write($"Enter score #{pos + 1}: ");
            float.TryParse(Console.ReadLine(), out sneakyScores[pos]);
        }

        for (int spot = 0; spot < sneakyScores.Length; spot++)
        {
            float tempVal = sneakyScores[spot];
            string alphaMark = "";

            if (tempVal >= 90 && tempVal <= 100)
                alphaMark = "A";
            else if (tempVal >= 80)
                alphaMark = "B";
            else if (tempVal >= 70)
                alphaMark = "C";
            else if (tempVal >= 60)
                alphaMark = "D";
            else
                alphaMark = "F";

            gradeBox[spot] = alphaMark;

            Console.WriteLine($"Score: {tempVal} => Grade: {alphaMark}");

            switch (alphaMark)
            {
                case "A":
                    Console.WriteLine("Solid work, you're flying.");
                    break;
                case "B":
                    Console.WriteLine("Not bad, you're cruising.");
                    break;
                case "C":
                    Console.WriteLine("Alright, but could push more.");
                    break;
                case "D":
                    Console.WriteLine("Yikes, on thin ice.");
                    break;
                case "F":
                    Console.WriteLine("Fumbled it hard. Try again.");
                    break;
                default:
                    Console.WriteLine("Grade unknown. Weird.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
