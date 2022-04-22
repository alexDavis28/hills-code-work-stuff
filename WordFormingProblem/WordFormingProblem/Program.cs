using System;

namespace WordFormingProblem
{
    // to do: 2 arrays of 26 elements (alphabet)
    // count occurences of each letter in first word and store in corresponding spot in array
    // repeat for second word
    // compare arrays
    class Program
    {
        static void Main(string[] args)
        {

            SecondMethod();

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

        static void SecondMethod()
        {
            string first_word = Console.ReadLine().ToUpper();
            string second_word = Console.ReadLine().ToUpper();

            int[] one = new int[26];
            int[] two = new int[26];

            foreach (char c in first_word)
            {
                one[(int)c - 65] += 1;
            }

            foreach (char c in second_word)
            {
                two[(int)c - 65] += 1;
            }

            bool valid = true;

            

            for (int i = 0; i < one.Length; i++)
            {
                if (one[i] > two[i])
                {
                    valid = false;
                }
            }

            if (valid)
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
