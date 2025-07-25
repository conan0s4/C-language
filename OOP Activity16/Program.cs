using System;

class Program
{
    static void Main()
    {
        Console.Write("no1: ");
        string input1 = Console.ReadLine();
        Console.Write("no2: ");
        string input2 = Console.ReadLine();
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        float num1, num2;

        // Validate that both inputs are float numbers
        if (float.TryParse(input1, out num1) && float.TryParse(input2, out num2))
        {
            switch (op) //operator options
            {
                case "+":
                    Console.WriteLine($"Result: {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {num1 * num2}");
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        Console.WriteLine($"Result: {num1 / num2}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator. Use +, -, *, or /.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error");
        }
    }
}

