using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> prodBin = new List<string>();
        List<int> qtyBin = new List<int>();
        List<bool> wasRefilled = new List<bool>();

        for (int slot = 0; slot < 10; slot++)
        {
            Console.Write("item name: ");
            string itemTag = Console.ReadLine();
            Console.Write("stock: ");
            int.TryParse(Console.ReadLine(), out int stashNum);

            if (stashNum < 10)
            {
                stashNum += 20;
                wasRefilled.Add(true);
            }
            else
            {
                wasRefilled.Add(false);
            }

            prodBin.Add(itemTag);
            qtyBin.Add(stashNum);
        }

        Console.WriteLine("\nupdated list:");
        for (int lane = 0; lane < prodBin.Count; lane++)
        {
            string refillNote = wasRefilled[lane] ? "(restocked)" : "";
            Console.WriteLine($"{prodBin[lane]} - {qtyBin[lane]} {refillNote}");
        }
    }
}





