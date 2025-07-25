using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        
        
        
        int age;




        // if input is a valid non-negative integer, categorize the age
        if (int.TryParse(input, out age) && age >= 0) // both requirements are checked == must be met
        {
            if (age < 1) Console.WriteLine("Invalid"); 
            
            else if (age <= 12)
                Console.WriteLine("Category: Child");
            
            else if (age <= 19)
                Console.WriteLine("Category: Teen");
            else if (age <= 59)
                Console.WriteLine("Category: Adult");
            else if (age <= 129)
                Console.WriteLine("Category: Senior");
            else 
            Console.WriteLine("Invalid input.");


        
        
        }
    }
}

