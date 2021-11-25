using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator program\n");

            // Ask the user for two number and store them as floats
            Console.WriteLine("Enter the first number: ");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            float number2 = float.Parse(Console.ReadLine());

            // Output the menu options
            Console.WriteLine("\nEnter the menu number of the calculation to perform: ");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division\n");

            // Ask for the menu option
            string menuOption = Console.ReadLine();

            // Perform a subroutine based on the menu option
            if (menuOption == "1")
            {
                Console.WriteLine(Addition(number1, number2)); ;
            }
            else if (menuOption == "2")
            {
                Console.WriteLine(Subtraction(number1, number2)); ;
            }
            else if (menuOption == "3")
            {
                Console.WriteLine(Multiplication(number1, number2)); ;
            }
            else if (menuOption == "4")
            {
                Console.WriteLine(Division(number1, number2)); ;
            }
            else
            {
                Console.WriteLine("Please choose a valid option");
            }
        }

        // The addition procedure has two floats as parameters, adds them together and outputs the result
        static float Addition(float num1, float num2)
        {
            return num1 + num2;
        }

        static float Subtraction(float num1, float num2)
        {
            return num1 - num2;
        }

        static float Multiplication(float num1, float num2)
        {
            return num1 * num2;
        }
        static float Division(float num1, float num2)
        {
            return num1 / num2;
        }
    }
}
