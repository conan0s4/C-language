using System;
using System.Diagnostics;

namespace OOP_Activity
{
    internal class Activity01
    {
        static void Main(string[] args)
        {







            Console.WriteLine("(School registration System)");
            while (true)
            {



                Console.Write("Please enter your first_name: ");
                string firstNAME = Console.ReadLine();
                Console.Write("Please enter your last_name: ");
                string lastNAME = Console.ReadLine();


                //if both are empty , ask for input again
                if (String.IsNullOrEmpty(firstNAME) || String.IsNullOrEmpty(lastNAME))
                {
                    //loop back
                    Console.WriteLine("please input again.");
                    continue; //continue the loop if either input is empty

                }
                else
                {
                    //if both are not empty, print welcome message
                    Console.Write("Welcome " + firstNAME + " " + lastNAME + " to IDSC! ");
                    break; //break the loop if both inputs are valid

                }


            }











        }
    }
}









