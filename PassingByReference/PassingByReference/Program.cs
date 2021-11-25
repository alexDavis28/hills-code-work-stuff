using System;

namespace PassingByReference
{
    class Program
    {
        static void Main()
        {
            double pay;
            pay = 2000;

            CalculatePay(ref pay);
            Console.WriteLine(pay);
            // Prediction: 1560

            pay = 2000;
            Bonus(ref pay);
            Console.WriteLine(pay);
        }

        // Function to calculate deductions from pay
        static double SubtractDeductions(double pay, double percent)
        {
            return (pay * percent) / 100;
        }

        static void CalculatePay(ref double pay)
        {
            // Subtract tax on pay at 22%
            pay = pay - SubtractDeductions(pay, 22);
        }

        static void Bonus(ref double pay)
        {
            pay -= SubtractDeductions(pay, 22);
            pay *= 1.05;
        }
    }
}
