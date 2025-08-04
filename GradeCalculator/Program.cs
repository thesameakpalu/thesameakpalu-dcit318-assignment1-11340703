using System;

namespace GradeCalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Outer loop to allow multiple grade checks
            {
                int grade;

                while (true) // Inner loop to validate grade input
                {
                    Console.Write("Enter a grade (0-100): ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out grade))
                    {
                        if (grade < 0 || grade > 100)
                        {
                            Console.WriteLine("Invalid grade. Must be between 0 and 100.\n");
                            continue;
                        }

                        // Block to check grade output
                        if (grade >= 90)
                            Console.WriteLine("Grade: A (Excellent)");
                        else if (grade >= 80)
                            Console.WriteLine("Grade: B (Very Good)");
                        else if (grade >= 70)
                            Console.WriteLine("Grade: C (Good)");
                        else if (grade >= 60)
                            Console.WriteLine("Grade: D (Average)");
                        else
                            Console.WriteLine("Grade: F (Fail)");

                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.\n");
                    }
                }

                // Checking whether User  wants to exit
                Console.Write("\nDo you want to enter another grade? (y/n): ");
                string answer = Console.ReadLine().Trim().ToLower();

                if (answer != "y" && answer != "yes")
                {
                    Console.WriteLine("Exiting... Thank you!");
                    break;
                }

                Console.WriteLine(); //  space before next entry
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
