using System;

class TimeConversionTool
{
    static void Main()
    {
        int[] durations = new int[10];
        Console.WriteLine("Enter 10 durations in seconds:");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Duration {i + 1} (in seconds): ");
            durations[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nSeconds   ->   HH:MM:SS");
        Console.WriteLine("----------------------------");

        for (int i = 0; i < 10; i++)
        {
            int totalSeconds = durations[i];
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine($"{totalSeconds,7}   ->   {hours:D2}:{minutes:D2}:{seconds:D2}");
        }
    }
}
