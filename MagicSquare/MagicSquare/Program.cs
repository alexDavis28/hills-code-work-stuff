using System;

namespace MagicSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] square = { { 8, 1, 6 }, { 3, 5, 7 }, { 4, 9, 2 } };

            bool is_magic = true;

            int square_total = 0;
            for (int i = 0; i < square.GetLength(1); i++)
            {
                square_total += square[0, i];
            }

            // Check rows

            for (int row = 0; row < square.GetLength(0); row++)
            {
                int row_total = 0;
                for (int col = 0; col < square.GetLength(1); col++)
                {
                    row_total += square[row, col];
                }
                is_magic = row_total == square_total;
            }

            // check columns

            for (int col = 0; col < square.GetLength(0); col++)
            {
                int col_total = 0;
                for (int row = 0; row < square.GetLength(1); row++)
                {
                    col_total += square[col, row];
                }
                is_magic = col_total == square_total;
            }

            // check diagonals
            int dia_total_one = 0;
            for (int i = 0; i < square.GetLength(0); i++)
            {
                dia_total_one += square[i, i];
            }
            is_magic = dia_total_one == square_total;

            int dia_total_two = 0;
            int dia_total_two_row = 0;
            int dia_total_two_col = 2;
            for (int i = 0; i < square.GetLength(0); i++)
            {
                dia_total_two += square[dia_total_two_row, dia_total_two_col];
                dia_total_two_row++;
                dia_total_two_col--;
            }
            is_magic = dia_total_two == square_total;

            Console.WriteLine(is_magic);

        }
    }
}
