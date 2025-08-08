using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("[1] Greet");
        Console.WriteLine("[2] Show Date");
        Console.WriteLine("[3] Exit");
        Console.Write("Input (1-3): ");

        string input = Console.ReadLine();
        int choice;

        if (int.TryParse(input, out choice))
        {
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Hello, User!");
                    break;
                case 2:  
                    Console.WriteLine("Current date: " + DateTime.Now.ToString("yyyy-MM-dd"));
                    break;  //soruce: https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1
                case 3:     //source: https://learn.microsoft.com/en-us/dotnet/api/system.datetime.tostring?view=net-9.0
                    Console.WriteLine("Exit...");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}

