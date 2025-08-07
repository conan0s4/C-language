using System;

class NotTheSameCode
{
    static void Main()
    {
        string[] batchOfNames = new string[3];

        for (int loopSpot = 0; loopSpot < 3; loopSpot++)
        {
            Console.Write($"drop name {loopSpot + 1}: ");
            batchOfNames[loopSpot] = Console.ReadLine();
        }

        foreach (string label in batchOfNames)
        {
            string bitOne = label.Substring(0, 1);
            string bitLast = label.Substring(label.Length - 1, 1);
            string bigBitOne = bitOne.ToUpper();
            string bigBitLast = bitLast.ToUpper();

            Console.WriteLine($"raw: {label} | first: {bitOne} | last: {bitLast} | UPPER: {bigBitOne}{bigBitLast}");
        }
    }
}
