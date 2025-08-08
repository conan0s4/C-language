using System;

class Program
{
    static void Main()
    {
        string correctUsername = "admin";
        string correctPassword = "1234";

        string username;
        string password;

        do
        {
            Console.Write("Enter username: ");
            username = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();
            // Check if the entered username and password match the correct ones
            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Login successful");
            }
            else
            {
                Console.WriteLine("Try again\n");
            }
            // This loop continues until the correct username and password are entered
        } while (username != correctUsername || password != correctPassword);
    }
}

