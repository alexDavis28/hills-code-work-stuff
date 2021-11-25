using System;

namespace String_checking
{
    class Program
    {
        static void Main(string[] args)
        {
            string base_string = "I am going to check every word of this sentence for the keywords";
            string[] words = base_string.Split();
            foreach (string word in words)
            {
                switch (word)
                {
                    case "check":
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "word":
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        break;
                    case "sentence":
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        break;
                    default:
                        break;
                }
                Console.Write(word);
                Console.ResetColor();
                Console.Write(" ");
            }
        }
    }
}
