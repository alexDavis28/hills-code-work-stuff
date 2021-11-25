using System;

namespace HRSFC_Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Convert farenheit to celsius
            while (true)
            {
                double fahrenheit;
                string userInput = Console.ReadLine();
                try
                {
                    fahrenheit = double.Parse(userInput);
                }
                catch (FormatException)
                {
                    if (userInput == "q")
                    {
                        break;
                    }
                    Console.WriteLine("Enter a number");
                    continue;
                }

                double celsius = (((fahrenheit - 32) / 9) * 5);

                Console.WriteLine(Math.Round(celsius, 2));
            }
        }
    }
}
