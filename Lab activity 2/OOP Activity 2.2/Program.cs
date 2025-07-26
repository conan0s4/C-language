using System;

class CalendarEventOrganizer
{
    static void Main()
    {
        string[] eventNames = new string[5];
        DateTime[] eventDates = new DateTime[5];

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter name of event " + (i + 1) + ": ");
            eventNames[i] = Console.ReadLine();

            DateTime dateInput;
            bool validDate = false;

            while (!validDate)
            {
                Console.Write("Enter date (MM/DD/YYYY) for \"" + eventNames[i] + "\": ");
                string input = Console.ReadLine();

                // Check if date is valid
                if (DateTime.TryParse(input, out dateInput))
                {
                    // Check for duplicate dates
                    bool duplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (eventDates[j] == dateInput)
                        {
                            duplicate = true;
                            Console.WriteLine("❌ Error: Another event already has this date. Try again.");
                            break;
                        }
                    }

                    if (!duplicate)
                    {
                        eventDates[i] = dateInput;
                        validDate = true;
                    }
                }
                else
                {
                    Console.WriteLine("❌ Invalid date format. Please use MM/DD/YYYY.");
                }
            }
        }

        // Sort events by date using bubble sort
        for (int i = 0; i < 4; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (eventDates[i] > eventDates[j])
                {
                    // Swap dates
                    DateTime tempDate = eventDates[i];
                    eventDates[i] = eventDates[j];
                    eventDates[j] = tempDate;

                    // Swap corresponding event names
                    string tempName = eventNames[i];
                    eventNames[i] = eventNames[j];
                    eventNames[j] = tempName;
                }
            }
        }

        // Output sorted events
        Console.WriteLine("\n📅 Sorted Events:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(eventDates[i].ToString("MM/dd/yyyy") + " - " + eventNames[i]);
        }
    }
}
