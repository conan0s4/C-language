using System;

class DispatchCore
{
    static void Main()
    {
        string[] signsVault = new string[5];

        for (int loopy = 0; loopy < 5; loopy++)
        {
            Console.Write("State symptom: ");
            string blurInput = Console.ReadLine().ToLower();
            signsVault[loopy] = blurInput;

            if (blurInput == "fever" || blurInput == "cough")
            {
                Console.WriteLine("Assign: General Medicine");
            }
            else if (blurInput == "injury" || blurInput == "burn")
            {
                Console.WriteLine("Assign: Emergency");
            }
            else
            {
                Console.WriteLine("Assign: Refer to Specialist");
            }
        }
    }
}
