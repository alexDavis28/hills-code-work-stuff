using System;

namespace ArraySubsets
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] A = new int[5];
            int[] B = new int[20];

            for (int i = 0; i < A.Length; i++)
            {
                A[i] = random.Next(1, 10);
            }

            for (int i = 0; i < B.Length; i++)
            {
                B[i] = random.Next(1, 10);
            }

            Array.Sort(A);
            Array.Sort(B);

            Console.WriteLine("\nA: ");
            foreach (int num in A)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\nB: ");
            foreach (int num in B)
            {
                Console.Write(num + " ");
            }

            bool subset = true;
            bool match = false;
            foreach (int num_a in A)
            {
                match = false;
                foreach (int num_b in B)
                {
                    if (num_a==num_b)
                    {
                        match = true;
                    }
                }
                if (!match)
                {
                    subset = false;
                }
            }

            if (subset)
            {
                Console.WriteLine("\nA is a subset of B");
            }
            else
            {
                Console.WriteLine("\nA is not a subset of B");
            }


        }
    }
}
