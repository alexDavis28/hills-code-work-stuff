using System;

namespace Times_tables
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            string input = "";
            int table = 0;
            while (!validAnswer)
            {
                Console.Write("Times table to calculate: ");
                input = Console.ReadLine();
                validAnswer = int.TryParse(input, out table);
            }

            for (int i = 1; i < 13; i++)
            {
                Console.WriteLine($"{i}x{table} = {i*table}");
            }
        }
    }
}
