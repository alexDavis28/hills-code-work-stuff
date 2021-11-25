using System;

namespace MeasurementConversion
{
    class Program
    {
        // Global variables

        static void Main(string[] args)
        {
            // Call the Menu() procedure
            
            Menu();
            
        }

        // Procedure to present a menu of choices to the user
        static void Menu()
        {
            bool running = true;
            while (running)
            {


                int choice;

                // Output the menu choices
                Console.WriteLine("\nChoose a menu option 1-3");
                Console.WriteLine("1. cm to inches");
                Console.WriteLine("2. inches to cm");
                Console.WriteLine("3. Quit");

                // Check that the user choice is valid
                do
                {
                    Console.Write("\nEnter menu choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                while (choice < 1 || choice > 3);

                // Call the approriate subroutine



                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("\nEnter cm: ");
                            Console.WriteLine(CmToInches(Console.ReadLine()));
                            break;
                        }

                    case 2:
                        {
                            Console.Write("\nEnter inches: ");
                            Console.WriteLine(InchesToCm(Console.ReadLine()));
                            break;
                        }

                    case 3:
                        {
                            running = false;
                            break;
                        }
                }
            }
        }

        // Procedure to convert cm to inches
        static string CmToInches(string input)
        {
            double cm;
            double inches;
            // Ask the user to input cm
            cm = Convert.ToDouble(input);

            // Convert cm to inches
            inches = cm * 0.393700787;
            return inches + " inches";
        }

        // Procedure to convert inches to cm
        static string InchesToCm(string input)
        {
            double cm;
            double inches;
            // Ask the user to input inches
            inches = Convert.ToDouble(input);

            // Convert inches to cm
            cm = inches * 2.54;
            return cm + " cm";
        }
    }
}