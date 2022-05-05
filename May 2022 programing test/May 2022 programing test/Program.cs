using System;
using System.Collections.Generic;

namespace May_2022_programing_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> bits = new List<int> { };
            Console.WriteLine("Enter the decimal number: ");
            int input = Convert.ToInt32(Console.ReadLine());

            int result = input;

            while (result > 0)
            {
                bits.Add(result % 2);
                result /= 2;
            }

            bits.Reverse();

            foreach (int bit in bits)
            {
                Console.Write(bit);
            }
        }
    }
}
