using System;
using System.Collections.Generic;

namespace May_2022_programing_test_Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter input string: ");
            string input = Console.ReadLine();

            List<char> characters = new List<char> { };
            List<int> instances = new List<int> { };

            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    characters.Add(input[i]);
                    instances.Add(1);
                }
                else
                {
                    if (input[i] == characters[count])
                    {
                        instances[count] += 1;
                    }
                    else
                    {
                        count++;
                        characters.Add(input[i]);
                        instances.Add(1);
                    }
                }
            }

            string compressed_text = "";

            for (int i = 0; i < characters.Count; i++)
            {
                compressed_text = compressed_text + characters[i] + " " + instances[i] + " ";
            }
            Console.WriteLine(compressed_text);
        }
    }
}
