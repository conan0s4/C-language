using System;

namespace program
{
    internal class Activity03
    {
        static void Main(string[] args)
        {
            

            

            while (true)
            {

                Console.Write("price: ");
                string price = Console.ReadLine();
                Console.Write("quantity: ");
                string quantity = Console.ReadLine();

                float cprice = float.Parse(price);
                int cquantity = int.Parse( quantity);

                //if the price or quantity is less than 0, display an error message and prompt for input again
                if (cprice < 0 || cquantity < 0)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {   //if the price and quantity are valid, calculate the total cost
                    float total = cprice * cquantity;
                    Console.WriteLine("Total cost: php " + total);
                    break;
                }
                }
            

        }
    }
}
