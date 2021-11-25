using System;
using System.Collections.Generic;

namespace Prime_Factorisation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int output = 1;
            foreach (var factor in PrimeFactorsOf(num))
            {
                output *= factor;
            }
            Console.WriteLine(output);
            Console.WriteLine(IsPrime(num));

        }

        static List<int> PrimeFactorsOf(int num)
        {
            List<int> Factors = new List<int> {};

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0 && IsPrime(i))
                {
                    Factors.Add(i);
                }
            }

            if (IsPrime(num))
            {
                Factors.Add(num);
            }

            return Factors;
        }

        static bool IsPrime(int num)
        {
            List<int> Factors = new List<int> { num };

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Factors.Add(i);
                }
            }

            return Factors.Count == 2;
        }

        static List<int> FactorsOf(int num)
        {
            List<int> Factors = new List<int> {num};

            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Factors.Add(i);
                }
            }
            return Factors;
        }
    }
}
