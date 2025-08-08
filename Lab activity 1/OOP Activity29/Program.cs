using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter start number: ");
        string startInput = Console.ReadLine();
        Console.Write("Enter end number: ");
        string endInput = Console.ReadLine();

        int start, end;

        // Validate input and parse integers
        if (int.TryParse(startInput, out start) && int.TryParse(endInput, out end) && start < end)
        {// Proceed with finding prime numbers
            Console.WriteLine("\nPrime numbers between {0} and {1}:", start, end);// Print the range of prime numbers
            for (int number = start; number <= end; number++)// Loop through each number in the range
            {
                if (number < 2) 
                    continue; // Skip numbers less than 2, as they are not prime

                bool isPrime = true; // Assume the number is prime initially

                for (int i = 2; i < number; i++) // Check divisibility from 2 to number-1
                {
                    if (number % i == 0)// If the number is divisible by any number other than 1 and itself
                    {
                        isPrime = false;
                        break;// Set isPrime to false and break the loop
                    }
                }

                if (isPrime)
                {// If the number is prime, print it
                    Console.WriteLine(number);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    }
}

