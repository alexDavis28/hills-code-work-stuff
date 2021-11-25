using System;

namespace CeaserCipherFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            string text = System.IO.File.ReadAllText(@"C:\Users\8m3xl\Desktop\text.txt").ToUpper();

            for (int i = 0; i < alpha.Length; i++)
            {
                int count = OccurencesOf(text, alpha[i]);
                Console.WriteLine($"{alpha[i]} occurs {count} times.");
            }
            
        }

        static void Decrypt(string text, int shift)
        {
            char[] input = text.ToUpper().ToCharArray();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    //Console.WriteLine(i);
                    //Console.WriteLine(input[i]);
                    Console.Write(alpha[(Array.IndexOf(alpha, input[i]) + shift) % 26]);
                }
                else
                {
                    Console.Write(input[i]);
                }
            }
            Console.WriteLine("");
        }

        static int OccurencesOf(string text, char c)
        {
            int count = 0;
            foreach (char letter in text)
            {
                if (letter==c)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
