using System;
using System.Collections.Generic;

namespace _5._5._1_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program 1
            Console.WriteLine(IsPrime(6));
            int n = int.Parse(Console.ReadLine());
            var prime_factors = PrimeFactorsOf(n);
            prime_factors.ForEach(Console.WriteLine);

        }

        public static List<int> PrimeFactorsOf(int n)
        {

            var factors_of_n = new List<int>();
            int max = (int)Math.Sqrt(n);

            for (int factor = 1; factor <= max; ++factor)
            {
                Console.WriteLine(n % factor == 0 & IsPrime(factor));
                if (n % factor == 0 & IsPrime(factor))
                {
                    factors_of_n.Add(factor);
                    if (factor != n / factor)
                        factors_of_n.Add(n / factor);
                }
            }
            return factors_of_n;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }

    }
}
