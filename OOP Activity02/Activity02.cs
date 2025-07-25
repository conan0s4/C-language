using System;

namespace OOP_Activity02
{
    internal class Activity02
    {
        static void Main(string[] args)

        {

            Console.WriteLine("(AGe to MonThs ConVerTer)");





            while (true)
            {

                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();

                int age = int.Parse(input);

                //if age is less than 1 or greater than 120, print "error" and continue the loop
                if (age < 1 || age > 120)
                {

                    Console.WriteLine("error");
                    continue;



                }
                else
                {
                    //formula: months = age * 12

                    int result = age * 12;
                    //print the result
                    Console.WriteLine("your age " + result + " months old.");
                    break;


                }



            }











            }
        }
}
