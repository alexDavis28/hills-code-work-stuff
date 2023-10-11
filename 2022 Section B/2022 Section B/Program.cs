using System;

namespace _2022_Section_B
{
    class Program
    {
        static void Main(string[] args)
        {
            // get censored string and list of missing vowels
            Console.WriteLine("Enter censored string: ");
            string censored_string = Console.ReadLine();
            Console.WriteLine("Enter missing vowels: ");
            string missing_vowels = Console.ReadLine();

            Console.WriteLine(uncensor(censored_string, missing_vowels));
        }

        static string uncensor(string censored_string, string missing_vowels)
        {
            // esablish list of vowels
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            // check if non-vowel character in list of missing vowels
            foreach (char c in missing_vowels)
            {
                bool is_vowel = false;
                foreach (char v in vowels)
                {
                    if (c == v)
                    {
                        is_vowel = true;
                    }
                }

                if (!is_vowel)
                {
                    return "error non-vowel present";
                }
            }
            // iterate over string,
            int star_count = 0;
            char[] censored_string_array = censored_string.ToCharArray();
            for (int i = 0; i < censored_string_array.Length; i++)
            {
                // find nth *
                if (censored_string_array[i]=='*')
                {
                    // and replace with nth missing vowels
                    censored_string_array[i] = missing_vowels[star_count];
                    star_count++;
                }
            }

            censored_string = string.Concat(censored_string_array);


            // check if number of replaced vowels is different

            if (star_count < missing_vowels.Length)
            {
                return "error";
            }
            else
            {
                return censored_string;
            }

        }
    }
}
