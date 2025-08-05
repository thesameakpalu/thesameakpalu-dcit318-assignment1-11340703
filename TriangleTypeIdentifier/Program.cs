using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string continueOption;

            do
            {
                Console.Clear();
                Console.WriteLine("=== Triangle Type Identifier ===");

                Console.Write("Enter Side 1: ");
                double side1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Side 2: ");
                double side2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Side 3: ");
                double side3 = Convert.ToDouble(Console.ReadLine());

                // Check for triangle validity
                if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
                {
                    if (side1 == side2 && side2 == side3)
                    {
                        Console.WriteLine("Result: Equilateral Triangle");
                    }
                    else if (side1 == side2 || side1 == side3 || side2 == side3)
                    {
                        Console.WriteLine("Result: Isosceles Triangle");
                    }
                    else
                    {
                        Console.WriteLine("Result: Scalene Triangle");
                    }
                }
                else
                {
                    Console.WriteLine("The values entered do not form a valid triangle.");
                }

                Console.Write("\nDo you want to check another triangle? (y/n): ");
                continueOption = Console.ReadLine().ToLower();

            } while (continueOption == "y" || continueOption == "yes");

            Console.WriteLine("Goodbye!");
        }
    }
}