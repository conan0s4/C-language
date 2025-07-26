using System;

class BookInventoryManager
{
    static void Main()
    {
        string[] books = new string[20];
        int[] quantities = new int[20];
        int count = 0;

        Console.WriteLine("=== Add Books to Inventory ===");
        for (int i = 0; i < 5; i++) // you can increase this number
        {
            Console.Write("Enter book title: ");
            books[count] = Console.ReadLine();

            Console.Write("Enter quantity: ");
            quantities[count] = int.Parse(Console.ReadLine());

            count++;
        }

        Console.WriteLine("\n=== Search and Update ===");
        Console.Write("Enter book title to search: ");
        string search = Console.ReadLine();

        bool found = false;
        for (int i = 0; i < count; i++)
        {
            if (books[i].Equals(search, StringComparison.OrdinalIgnoreCase))
            {
                found = true;
                Console.WriteLine($"Book found. Current quantity: {quantities[i]}");
                Console.Write("Enter new quantity: ");
                quantities[i] = int.Parse(Console.ReadLine());
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Book not found in inventory.");
        }

        Console.WriteLine("\n=== Full Inventory ===");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{books[i]} - {quantities[i]} copies");
        }
    }
}

