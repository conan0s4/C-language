using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();
        int number;

        if (int.TryParse(input, out number))
        {   // if  number % by 2 it's remainder is 0 then it's even number otherwise odd number
            if (number % 2 == 0)
            {
                Console.WriteLine("Even number");
            }
            else
            {
                Console.WriteLine("Odd number");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }
}
