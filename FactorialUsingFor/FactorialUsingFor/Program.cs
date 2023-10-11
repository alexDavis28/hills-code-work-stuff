using System;

namespace FactorialUsingFor
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            Console.WriteLine(IterativeFactorial(input));
            Console.WriteLine(RecursiveFactorial(input));
            Console.WriteLine("\n");

            long x = long.Parse(Console.ReadLine());
            long y = long.Parse(Console.ReadLine());
            Console.WriteLine(EuclidsAlgorithim(x, y));
            Console.WriteLine("\n");

            for (long i = 1; i < 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.WriteLine("\n");

            x = long.Parse(Console.ReadLine());
            y = long.Parse(Console.ReadLine());
            Console.WriteLine(Power(x, y));
            Console.WriteLine("\n");

            Console.ReadLine();
        }

        static long IterativeFactorial(long num)
        {
            long tnum = num;
            for (long i = num; i > 1; i--)
            {
                num--;
                tnum *= num;
            }
            return tnum;
        }

        static long RecursiveFactorial(long num)
        {
            if (num == 1) // Base case
            {
                return 1;
            }
            else
            {
                return num * RecursiveFactorial(num - 1);
            }
        }

        static long EuclidsAlgorithim(long x, long y)
        {
            if (y==0)
            {
                return x;
            }
            else
            {
                return EuclidsAlgorithim(y, x % y);
            }
        }

        static long Fibonacci(long n)
        {
            if (n<=2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        static long Power(long x, long y)
        {
            if (y==0)
            {
                return 1;
            }
            else
            {
                return x * Power(x, y - 1);
            }
        }
    }
}
