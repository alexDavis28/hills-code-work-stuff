using System;

namespace MergingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 5, 20, 31, 35, 40 };
            int[] B = { 7, 10, 22, 25, 30 };
            //int[] A = { 1, 55, 72, 100, 452 };
            //int[] B = { 7, 12, 42, 50, 90 };

            int[] C = new int[A.Length + B.Length];


            int a_pos = 0;
            int b_pos = 0;
            int c_index = 0;

            bool merging = true;

            while (merging)
            {
                if (A[a_pos] < B[b_pos])
                {
                    C[c_index] = A[a_pos];
                    a_pos++;
                    c_index++;
                }
                else if (A[a_pos] > B[b_pos])
                {
                    C[c_index] = B[b_pos];
                    b_pos++;
                    c_index++;
                }

                if (a_pos >= A.Length)
                {
                    for (int i = b_pos; i < B.Length; i++)
                    {
                        C[c_index] = B[i];
                        c_index++;
                    }
                    merging = false;
                }
                else if (b_pos >= B.Length)
                {
                    for (int i = a_pos; i < A.Length; i++)
                    {
                        C[c_index] = A[i];
                        c_index++;
                    }
                    merging = false;
                }
            }

            Array.ForEach(C, Console.WriteLine);

            
        }
    }
}
