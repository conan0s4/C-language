using System;

class MemoryGame
{
    static char[,] board = new char[4, 4];
    static bool[,] revealed = new bool[4, 4];

    static void Main()
    {
        // Step 1: Initialize letters (A-H) twice and shuffle
        char[] letters = new char[16];
        for (int i = 0; i < 8; i++)
        {
            letters[i] = (char)('A' + i);
            letters[i + 8] = (char)('A' + i);
        }

        Shuffle(letters);

        // Step 2: Assign to board
        int index = 0;
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                board[row, col] = letters[index++];
                revealed[row, col] = false;
            }
        }

        // Step 3: Game loop
        int matches = 0;
        while (matches < 8)
        {
            Console.Clear();
            ShowBoard();

            Console.WriteLine("\nPick two cards to reveal (format: row col)");
            int r1, c1, r2, c2;

            // Input and validation for first pick
            while (true)
            {
                Console.Write("First pick (row col): ");
                if (ReadPosition(out r1, out c1) && !revealed[r1, c1])
                    break;
                Console.WriteLine("Invalid or already revealed. Try again.");
            }

            // Input and validation for second pick
            while (true)
            {
                Console.Write("Second pick (row col): ");
                if (ReadPosition(out r2, out c2) && !(r1 == r2 && c1 == c2) && !revealed[r2, c2])
                    break;
                Console.WriteLine("Invalid, same as first, or already revealed. Try again.");
            }

            // Temporarily reveal picks
            Console.Clear();
            ShowBoard(r1, c1, r2, c2);

            // Check for match
            if (board[r1, c1] == board[r2, c2])
            {
                Console.WriteLine("✅ Match found!");
                revealed[r1, c1] = true;
                revealed[r2, c2] = true;
                matches++;
            }
            else
            {
                Console.WriteLine("❌ Not a match.");
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        Console.Clear();
        ShowBoard();
        Console.WriteLine("\n🎉 Congratulations! You found all pairs!");
    }

    static void Shuffle(char[] array)
    {
        Random rand = new Random();
        for (int i = array.Length - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            char temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }

    static void ShowBoard(int r1 = -1, int c1 = -1, int r2 = -1, int c2 = -1)
    {
        Console.WriteLine("   0 1 2 3");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(i + "  ");
            for (int j = 0; j < 4; j++)
            {
                if (revealed[i, j] || (i == r1 && j == c1) || (i == r2 && j == c2))
                    Console.Write(board[i, j] + " ");
                else
                    Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    static bool ReadPosition(out int row, out int col)
    {
        string[] parts = Console.ReadLine().Split();
        if (parts.Length == 2 &&
            int.TryParse(parts[0], out row) &&
            int.TryParse(parts[1], out col) &&
            row >= 0 && row < 4 && col >= 0 && col < 4)
        {
            return true;
        }

        row = col = -1;
        return false;
    }
}

