using System;

class ThermalFlip
{
    static void Main()
    {
        float[] chillyVault = new float[5];

        for (int flip = 0; flip < 5; flip++)
        {
            Console.Write("temp[" + (flip + 1) + "] in Celsius: ");
            string scoop = Console.ReadLine();
            float.TryParse(scoop, out chillyVault[flip]);
        }

        Console.WriteLine("\nConverted & Labeled Temps:\n");

        foreach (float frost in chillyVault)
        {
            float blaze = frost * 9 / 5 + 32;
            string label;

            if (frost < 15)
                label = "Cold";
            else if (frost <= 30)
                label = "Warm";
            else
                label = "Hot";

            Console.WriteLine($"Celsius: {frost}°C => Fahrenheit: {blaze}°F = {label}");
        }
    }
}

