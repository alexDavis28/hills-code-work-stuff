using System;
using System.Collections.Generic;

namespace SectionB2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // input n
            int nthNumber = int.Parse(Console.ReadLine());
            List<int> harshadNumbers = new List<int> { };

            // iterate over numbers until list reaches nth
            int num = 1;
            while (harshadNumbers.Count < nthNumber)
            {
                // find sum of digits
                string num_as_string = Convert.ToString(num);
                int sum = 0;
                foreach (char c in num_as_string)
                {
                    sum += int.Parse(c.ToString());
                }
                // check if divisible by sum
                // if so add to list
                if (num%sum==0)
                {
                    harshadNumbers.Add(num);
                }
                num++;
            }
            Console.WriteLine(harshadNumbers[harshadNumbers.Count-1]);
        }
    }
}
