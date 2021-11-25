using System;

namespace Pounds_to_kilos
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{i}lb = {Math.Round(i*0.4536, 2)}kgs");
            }
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{i}lb = {Math.Round(i * 0.0714286, 2)}st");
            }
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine($"{i}lb = {Math.Round(i * 16.0, 2)}oz");
            }
        }
    }
}
