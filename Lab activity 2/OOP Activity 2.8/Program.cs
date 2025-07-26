using System;
using System.Collections.Generic;

class TransactionFilter
{
    static void Main()
    {
        List<decimal> transactions = new List<decimal>();
        List<decimal> highTransactions = new List<decimal>();
        decimal input, totalHigh = 0;

        Console.WriteLine("Enter 20 transaction amounts:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Transaction " + (i + 1) + ": ");
            input = decimal.Parse(Console.ReadLine());
            transactions.Add(input);

            if (input > 10000)
            {
                highTransactions.Add(input);
                totalHigh += input;
            }
        }

        Console.WriteLine("\nTransactions above 10,000:");
        foreach (decimal t in highTransactions)
        {
            Console.WriteLine("₱" + t.ToString("F2"));
        }

        Console.WriteLine("\nTotal of high transactions: ₱" + totalHigh.ToString("F2"));
    }
}

