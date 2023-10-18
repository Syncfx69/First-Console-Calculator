using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalagubangPrelimExamConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set console text color to green and background color to black
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            // Clear the console
            Console.Clear();

            // Display the program title in the console
            Console.WriteLine("================================================================");
            Console.WriteLine("                      SAKSI NI JAVA CALCULATOR              ");
            Console.WriteLine("================================================================");

            // Display of a Happy perpetualite design using ASCII art
            Console.WriteLine(@" 
                  _.--""`-._
                .'          '.
               /   O      O   \
              :                :
              |                |   
              : ',          ,' :
               \  '-......-'  /
                '.          .'
                  '-......-'");

            while (true)
            {
                // Prompt the user for input
                Console.WriteLine("\nPlease enter your calculation:");
                Console.Write("First value: ");

                // Read and parse the user's input as the first value
                if (!double.TryParse(Console.ReadLine(), out double firstValue))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                Console.Write("Second value: ");

                // Read and parse the user's input as the second value
                if (!double.TryParse(Console.ReadLine(), out double secondValue))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                // Display a list of available operations
                Console.WriteLine("Choose the operation from the following list:");
                Console.WriteLine("a - Add");
                Console.WriteLine("s - Subtract");
                Console.WriteLine("m - Multiply");
                Console.WriteLine("d - Divide");

                // Prompt the user for the operation choice
                Console.Write("Enter operation: ");

                // Read and parse the user's input as the operation choice
                if (!char.TryParse(Console.ReadLine(), out char operationChoice) || !IsValidOperation(operationChoice))
                {
                    Console.WriteLine("Invalid choice. Please enter a valid operation choice (a, s, m, d).");
                    continue;
                }

                // Perform the selected operation and calculate the result
                double result = PerformOperation(firstValue, secondValue, operationChoice);

                // Display the calculation result
                Console.WriteLine($"Result: {result}");

                // Ask the user if they want to perform another calculation
                Console.Write("Do you want to perform another calculation? (y/n): ");
                char choice = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (choice == 'n' || choice == 'N')
                {
                    break; // Exit the loop if the user chooses not to perform another calculation
                }
            }

            // Reset console colors to their default values
            Console.ResetColor();
        }

        // Function to check if the selected operation is valid
        static bool IsValidOperation(char operation)
        {
            return operation == 'a' || operation == 's' || operation == 'm' || operation == 'd';
        }

        // Function to perform the selected operation and calculate the result
        static double PerformOperation(double firstValue, double secondValue, char operation)
        {
            switch (operation)
            {
                case 'a':
                    return firstValue + secondValue;
                case 's':
                    return firstValue - secondValue;
                case 'm':
                    return firstValue * secondValue;
                case 'd':
                    
                    if (secondValue == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return 0;
                    }
                    return firstValue / secondValue;
                default:
                    return 0; // This should not be reached
            }
        }
    }
}