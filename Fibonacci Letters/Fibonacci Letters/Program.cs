using System;

namespace Fibonacci_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter_a = LetterToNum(Convert.ToChar(Console.ReadLine().ToUpper()));
            int letter_b = LetterToNum(Convert.ToChar(Console.ReadLine().ToUpper()));
            int n;
            do
            {
                Console.WriteLine("N: ");
                n = int.Parse(Console.ReadLine());
            } while (n < 2);

            int out_num = F(letter_a, letter_b, n, 2);
            Console.WriteLine(NumToLetter(out_num));

        }

        static int F(int a, int b, int n, int c)
        {
            int new_num = (a + b) % 26;
            c++;
            if (c == n)
            {
                return new_num;
            }
            else
            {
                return F(b, new_num, n, c);
            }
        }

        static int LetterToNum(char c)
        {
            return ((int)c) - 64;
        }

        static char NumToLetter(int n)
        {
            return (char)(n + 64);
        }
    }
}
