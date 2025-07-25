using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter an integer: ");
            string input = Console.ReadLine();

            int number;
            if (int.TryParse(input, out number))
            {   //check input if integer -- “If the remainder % of /  num by 2 is equal to 0
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else 
                { 
                    Console.WriteLine("The number is odd.");
                }
                break; 
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}

