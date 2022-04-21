using System;

namespace WordFormingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_word = Console.ReadLine().ToUpper();
            string second_word = Console.ReadLine().ToUpper();
            string temp_word = first_word;

            for (int i = 0; i < second_word.Length; i++)
            {
                char c = second_word[i];
                if (temp_word.Contains(c))
                {
                    temp_word = temp_word.Remove(temp_word.IndexOf(c), 1);
                }
            }
            if (temp_word=="")
            {
                Console.WriteLine($"The word \"{first_word}\" can be created using the letters in \"{second_word}\"");
            }
            else
            {
                Console.WriteLine($"The word \"{first_word}\" can not be created using the letters in \"{second_word}\"");
            }
        }
    }
}
