using System;

namespace PassingByValue
{
    class Program
    {
        static void Main()
        {
            double pay;
            pay = 2000;

            
            Console.WriteLine(CalculatePay(pay));
            // Prediction: 2000
            Console.WriteLine(Bonus(2000));
        }

        // Function to calculate deductions from pay
        static double SubtractDeductions(double pay, double percent)
        {
            return (pay * percent) / 100;
        }

        static double CalculatePay(double pay)
        {
            // Subtract tax on pay at 22%
            pay = pay - SubtractDeductions(pay, 22);
            return pay;
        }

        static double Bonus(double pay)
        {
            pay -= SubtractDeductions(pay, 22);
            return pay * 1.05;
        }
    }
}
