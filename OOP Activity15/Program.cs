using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade (0–100): ");
        string input = Console.ReadLine();
        int grade;

        if (int.TryParse(input, out grade))
        {
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade. Must be between 0 and 100.");
            }
            else if (grade >= 90)
            {
                Console.WriteLine("Your grade is: A");
            }
            else if (grade >= 80)
            {
                Console.WriteLine("Your grade is: B");
            }
            else if (grade >= 70)
            {
                Console.WriteLine("Your grade is: C");
            }
            else if (grade >= 60)
            {
                Console.WriteLine("your grade is: D");
            }
            else
            {
                Console.WriteLine("Your grade is: F");
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}
















