using System;

class GateCheck
{
    static void Main()
    {
        string[] p0cket = new string[5];

        for (int jox = 0; jox < 5; jox++)
        {
            Console.Write($"Enter password {jox + 1}: ");
            p0cket[jox] = Console.ReadLine();
        }

        foreach (string locked in p0cket)
        {
            bool hasCaps = false;
            bool hasNum = false;
            bool hasSym = false;

            if (locked.Length < 8)
            {
                Console.WriteLine("Invalid");
                continue;
            }

            foreach (char z in locked)
            {
                if (char.IsUpper(z)) hasCaps = true;
                else if (char.IsDigit(z)) hasNum = true;
                else if ("!@#$%^&*()_+-=[]{}|;:',.<>/?".Contains(z)) hasSym = true;
            }

            if (hasCaps && hasNum && hasSym)
                Console.WriteLine("Strong");
            else
                Console.WriteLine("Weak");
        }
    }
}
