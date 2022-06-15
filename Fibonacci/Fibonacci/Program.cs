using System;
using System.Collections.Generic;
using System.Numerics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100000;
            List<BigInteger> numbers = new List<BigInteger> {1, 1};

            for (int i = 0; i < n; i++)
            {
                numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);
            }

            foreach (BigInteger num in numbers)
            {
                Console.WriteLine(num);
            }

        }
    }
}
