using System;

namespace String_Handling_notes
{
    class Program
    {
        static void Main(string[] args)
        {
            // string length
            // Length is a property, is read-only, 
            string str_length = "test for length";
            Console.WriteLine(str_length.Length);

            // indexing a string, works as strings are arrays of characters, returns a char
            string string_indexing = "hello";
            Console.WriteLine(string_indexing[0]);

            // iteration over a string

            string for_iteration = "abcdefgh";

            for (int i = 0; i < for_iteration.Length; i++)
            {
                Console.WriteLine(for_iteration[i]);
            }

            // only works on enumerable objects
            foreach (char letter in for_iteration)
            {
                Console.WriteLine(letter);
            }

            // index of

            // Returns index of first occurence of substring
            Console.WriteLine(string_indexing.IndexOf("l"));

            // Returns index of last occurcence of substring
            Console.WriteLine(string_indexing.LastIndexOf("l"));


            // substring
            // gets substring starting from specified character and continuing for rest of string

            string substring_string = "hello world";
            Console.WriteLine(substring_string.Substring(6));

            // case changing
            string upper = "ABC";
            string lower = "abc";
            Console.WriteLine(upper.ToLower());
            Console.WriteLine(lower.ToUpper());

            // concatenation
            Console.WriteLine("hello" + " " + "name" + "!");
            Console.WriteLine(string.Concat("hello ", "world"));

            // escape characters

            Console.WriteLine("you can use escape characters (\\n) to use \" and \n and other stuff");

            // empty strings
            string empty_string_method_one = "";
            string empty_string_method_two = string.Empty; // This is better
        }
    }
}
