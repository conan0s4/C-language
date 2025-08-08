using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> stashItems = new List<string>();
        bool keepLooping = true;

        while (keepLooping)
        {
            Console.WriteLine("\n1. Add item\n2. Remove item\n3. View cart\n4. Clear cart\n5. Exit");
            Console.Write("Pick option: ");
            string menuPick = Console.ReadLine();

            switch (menuPick)
            {
                case "1":
                    Console.Write("Item to add: ");
                    string addThing = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(addThing))
                        stashItems.Add(addThing);
                    break;

                case "2":
                    Console.Write("Item to remove: ");
                    string rmThing = Console.ReadLine();
                    if (stashItems.Contains(rmThing))
                        stashItems.Remove(rmThing);
                    else
                        Console.WriteLine("Not found in cart");
                    break;

                case "3":
                    if (stashItems.Count == 0)
                        Console.WriteLine("Cart empty");
                    else
                        Console.WriteLine("Cart: " + string.Join(", ", stashItems));
                    break;

                case "4":
                    stashItems.Clear();
                    Console.WriteLine("Cart cleared");
                    break;

                case "5":
                    keepLooping = false;
                    break;

                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }
    }
}
