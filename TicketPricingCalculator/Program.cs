using System;

namespace TicketPriceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.Write("Enter your age: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int age))
                {
                    if (age < 0)
                    {
                        Console.WriteLine("Invalid age entered.");
                    }
                    else if (age <= 12)
                    {
                        Console.WriteLine("Discounted Ticket Price: GHC7 (Child)");
                    }
                    else if (age >= 65)
                    {
                        Console.WriteLine("Discounted Ticket Price: GHC7 (Senior)");
                    }
                    else
                    {
                        Console.WriteLine("Standard Ticket Price: GHC10");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid numeric age.");
                }

                Console.Write("Do you want to check another ticket price? (y/n): ");
                string response = Console.ReadLine().Trim().ToLower();

                if (response != "y")
                {
                    keepRunning = false;
                }

                Console.WriteLine(); // blank line for spacing
            }

            Console.WriteLine("Thank you, See you soon");
        }
    }
}
