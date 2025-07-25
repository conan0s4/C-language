using System;
using System.Reflection.Metadata.Ecma335;

class OOP_Activity07
{
    static void Main()
    {

        while (true)
        {

            Console.WriteLine("no1:");
            string no1 = Console.ReadLine();
            Console.WriteLine("no2:");
            string no2 = Console.ReadLine();

            Console.WriteLine("enter operator:( + * - / ) ");
            string ope = Console.ReadLine();

            float num1 = float.Parse(no1);
            float num2 = float.Parse(no2);

            float result = 0;

            if (ope == "+") { result = num1 + num2; }
            else if (ope == "-") { result = num1 - num2; }
            else if (ope == "*") { result = num1 * num2; }
            else if (ope == "/")
            {
                if (num1 == 0 || num2 == 0) { Console.WriteLine("/ by 0 not allowed"); continue; }

                else { result = num1 / num2; }
            }

            else { Console.WriteLine("invalid"); }

            Console.WriteLine($"THe result is: {result}");
            break;


        }




    }

    }