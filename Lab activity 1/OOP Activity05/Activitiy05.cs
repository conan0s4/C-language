using System;
using System.ComponentModel.Design;

namespace OOP_Activity04
{
    internal class Activity05
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            float height;

            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                Console.Write("Enter your age: ");
                bool validAge = int.TryParse(Console.ReadLine(), out age);
                //conver string to int / string to float using tryparse
                Console.Write("Enter your height: ");
                bool validHeight = float.TryParse(Console.ReadLine(), out height);

                // Check if the inputs are valid
                // if empty / if not a int / float 
                if (string.IsNullOrEmpty(name) || !validAge || !validHeight)
                { //https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorempty?view=net-9.0
                    Console.WriteLine("Error: Invalid Datatype.");
                    continue;
                }
                // sourse: https://www.tutorialspoint.com/chash-int-tryparse-method
                // Input is valid
                break;
            }

            Console.WriteLine($"Name: {name}, Age: {age}, Height: {height}");


        }

    }
}
