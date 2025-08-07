using System;

class ClassyHeights
{
    static void Main()
    {
        int totalData = 6;
        int[] zAxisHeights = new int[totalData];
        int tiny = 0, mid = 0, tower = 0;

        for (int axis = 0; axis < totalData; axis++)
        {
            Console.Write($"Height #{axis + 1} in cm: ");
            string rough = Console.ReadLine();
            int nudge;

            if (int.TryParse(rough, out nudge))
            {
                zAxisHeights[axis] = nudge;

                if (nudge < 150)
                    tiny++;
                else if (nudge >= 150 && nudge <= 170)
                    mid++;
                else
                    tower++;
            }
            else
            {
                Console.WriteLine("invalid height, try again");
                axis--;
            }
        }

        Console.WriteLine($"\nShort folks: {tiny}");
        Console.WriteLine($"Average build: {mid}");
        Console.WriteLine($"Tall squad: {tower}");
    }
}
