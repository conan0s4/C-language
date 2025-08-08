using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your password: ");
        string password = Console.ReadLine();

        bool hasNumber = false;
        bool hasUpper = false;

        // Check for number and uppercase letter
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                hasNumber = true;
            }
            if (char.IsUpper(c))
            {
                hasUpper = true;
            }
        }

        bool isLengthValid = password.Length >= 8;

        //must have at least 8 characters, one number, and one uppercase letter
        // returns false if one of the conditions is not met
        if (isLengthValid && hasNumber && hasUpper)
        {
            Console.WriteLine("Valid password");
        }
        else
        {
            Console.WriteLine("Invalid password");

            if (!isLengthValid)
                Console.WriteLine("[-]must be at least 8 characters");
            if (!hasNumber)
                Console.WriteLine("[-]at least one number");
            if (!hasUpper)
                Console.WriteLine("[-] at least one uppercase letter");
        }
    }
}

