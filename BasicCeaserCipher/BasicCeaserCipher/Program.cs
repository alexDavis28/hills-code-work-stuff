using System;
using System.Text.RegularExpressions;

namespace BasicCeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string input_string = Console.ReadLine().ToUpper();
            char[] input = input_string.ToCharArray();

            for (int shift = 0; shift < 27; shift++)
            {
                Console.WriteLine($"Shift {shift}:");
                for (int i = 0; i < input.Length; i++)
                {
                    if (Char.IsLetter(input[i]))
                    {
                        //Console.WriteLine(i);
                        //Console.WriteLine(input[i]);
                        Console.Write(alpha[(Array.IndexOf(alpha, input[i]) + shift)%26]);
                    }
                    else
                    {
                        Console.Write(input[i]);
                    }
                }
                Console.WriteLine("");
            }
        }
    }
}
