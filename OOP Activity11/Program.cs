using System;

class Program
{
    static void Main()
    {
        string correctPIN = "1234";
        int attempts = 0;

        while (attempts < 3)
        {
            Console.Write("Enter your 4-digit PIN: ");
            string inputPIN = Console.ReadLine();

            if (inputPIN == correctPIN) // user input is == to the correct pin then grant access
            { 
                Console.WriteLine("Access granted");
                return; // Exit the program
            }
            else
            {
                attempts++;
                if (attempts == 3)
                {
                    Console.WriteLine("Access denied");
                }
            }
        }
    }
}

