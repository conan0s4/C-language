using System;

class PassJudge
{
    static void Main()
    {
        string[] bunchOfPwds = new string[4];
        for (int spot = 0; spot < 4; spot++)
        {
            Console.Write("pwd input " + (spot + 1) + ": ");
            bunchOfPwds[spot] = Console.ReadLine();
        }

        foreach (string attempt in bunchOfPwds)
        {
            bool passLong = attempt.Length >= 6;
            bool gotUpper = false;

            foreach (char letter in attempt)
            {
                if (char.IsUpper(letter))
                {
                    gotUpper = true;
                    break;
                }
            }

            if (passLong && gotUpper)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }
    }
}
