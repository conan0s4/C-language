using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        // if  input is not empty and contains only letters
        if (!string.IsNullOrEmpty(name) && IsAllLetters(name))
        {   // Format the name to have the first letter uppercase and the rest lowercase
            string formatname = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            Console.WriteLine("Formatted name: " + formatname);
        }  //specically 0 index is the first letter, and we convert it to uppercase sing char.ToUpper
        // and state(var[index]) then get substring starting from index 1 to the end of the string and convert it to lowercase using ToLower method.
        //sources: https://www.codecademy.com/resources/docs/c-sharp/strings/tolower
        //https://www.codecademy.com/resources/docs/c-sharp/strings/substring

        //https://www.geeksforgeeks.org/c-sharp/c-sharp-substring-method/

        else
        {
            Console.WriteLine("Invalid input. Please enter a non-empty alphabetic name.");
        }
    }

    static bool IsAllLetters(string input)
    {
        foreach (char c in input)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }
}
