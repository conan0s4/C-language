using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            bool valid = true;

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name required.");
                valid = false;
            }
            // Check if age is a valid integer and within a reasonable range
            if (!int.TryParse(ageInput, out int age) || age < 1 || age > 120)
            {
                Console.WriteLine("Invalid age.");
                valid = false;
            }
            // Check if email is not empty and contains an '@' character
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {//https://learn.microsoft.com/en-us/dotnet/api/system.string.contains?view=net-9.0
                Console.WriteLine("Invalid email.");
                valid = false;
            }
            
            if (valid)
            { // If all fields are valid, exit the loop
                Console.WriteLine("All fields are valid.");
                break;
            }
            // If any field is invalid, prompt the user to try again
            Console.WriteLine("Please try again.\n");
        }
    }
}












