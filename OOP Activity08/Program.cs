using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter a number as a string: ");
            string input = Console.ReadLine();

            

            int num;

            // will only be executed if the input is a valid integer
            if (int.TryParse(input , out num))
            {
                int result = num + 10;
                Console.WriteLine($"Result after adding 10: {result}");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
