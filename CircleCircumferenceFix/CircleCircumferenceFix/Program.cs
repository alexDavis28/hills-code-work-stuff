
using System;

namespace CircleCircumferenceFix
{
    class Program
    {
        static void Main(string[] args)

        {

            const double PI = Math.PI;

            double radius = 0.0;

            double diam;
                
            double circ;

            Console.WriteLine("Program to calculate the circumference of a circle");

            Console.Write("Enter circle radius: ");

            bool invalidInput = true;

            while (invalidInput)
            {
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                    invalidInput = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input");
                }
                
            }

            diam = radius * 2;

            circ = PI * diam;

            Console.WriteLine("The circumference of the circle = " + Math.Round(circ, 2));

            Console.ReadLine();

        }
    }
}
