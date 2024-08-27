using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the current day of the week
            Console.WriteLine("Please enter the current day of the week:");

            try
            {
                // Read the user input from the console
                string input = Console.ReadLine();

                // Try to convert the user input to the DayOfWeek enum type
                DayOfWeek currentDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), input, true);

                // Print the value of the enum if parsing was successful
                Console.WriteLine($"You entered: {currentDay}");
            }
            catch (ArgumentException)
            {
                // If parsing fails (e.g., user input is not a valid day), catch the exception
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
