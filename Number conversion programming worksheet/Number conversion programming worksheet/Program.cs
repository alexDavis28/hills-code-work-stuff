using System;

namespace Number_conversion_programming_worksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a binary number: ");
            string binaryString = Console.ReadLine();
            int binaryLength = binaryString.Length;
            int multiplier = 1;
            int denaryValue = 0;

            int digit;

            for (int i = 0; i < binaryLength; i++)
            {
                digit = Convert.ToInt32(binaryString[i]);
                denaryValue += digit * multiplier;
                Console.WriteLine(denaryValue);
                multiplier *= 2;
            }
            Console.WriteLine($"Denary value is {denaryValue}");
        }
    }
}
