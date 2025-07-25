using System;

internal class Activity_06
{
    static void Main(string[] args)
    {
        int grade;

        while (true)
        {
            Console.Write("Enter your numeric grade (0-100): ");
            bool isValid = int.TryParse(Console.ReadLine(), out grade);

            // Validate the input
            if (!isValid || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Grade must be an integer between 0 and 100.");
                continue;
            }

            break;
        }

        string letterGrade;

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {

            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your grade is: {letterGrade}");
    }
}










      