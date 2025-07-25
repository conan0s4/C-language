using System;

namespace OOP_Activity04
{
    internal class Activity04
    {
        static void Main(string[] args)
        {
            //formula: F = (C × 9/5) + 32

            
                Console.Write("Enter temperature in Celsius (-100 to 100): ");
                string INcelsius = Console.ReadLine();

                
                 float celsius = float.Parse(INcelsius);


            // Convert Celsius to Fahrenheit
            float fahrenheit = (celsius * 9 / 5) + 32;
                    Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);


                                              
                
           
        }
    }
}

