using System;

class EmailSnatchr
{
    static void Main()
    {
        string[] inboxDump = new string[5];
        for (int counter = 0; counter < 5; counter++)
        {
            Console.Write("Drop email #" + (counter + 1) + ": ");
            string scribbledMail = Console.ReadLine();

            if (string.IsNullOrEmpty(scribbledMail) || !scribbledMail.Contains("@") ||
                !(scribbledMail.EndsWith(".com") || scribbledMail.EndsWith(".edu")))
            {
                Console.WriteLine("nah that one's busted.");
                continue;
            }

            int dividerMark = scribbledMail.IndexOf('@');
            string pulledUser = scribbledMail.Substring(0, dividerMark);
            inboxDump[counter] = pulledUser;
            Console.WriteLine("yo, username: " + pulledUser);
        }
    }
}
