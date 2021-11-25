using System;

namespace _5._4_Extra_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem 1
            Console.WriteLine("Problem 1");
            for (int i = 32; i < 127; i++)
            {
                char charcter = (char)i;
                Console.WriteLine(charcter.ToString()); ;
            }

            // Problem 3
            Console.WriteLine("Problem 3");
            Console.WriteLine("Enter interest rate, num years and starting amount");
            double interest_rate = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            for (int i = 0; i <= years; i++)
            {
                Console.WriteLine($"After {i} years, there is £{money}");
                money *= (1 + interest_rate / 100);
            }

            // Problem 4
            Console.WriteLine("Problem 4");
            Console.WriteLine("Enter number");
            int num = int.Parse(Console.ReadLine());
            int power = 0;

            while (Math.Pow(2, power)<num)
            {
                power++;
            }
            Console.WriteLine($"2^{power} is greater than or equal to {num}");

            // Problem 5
            Console.WriteLine("Problem 5");
            double percent_cream = 100;
            int seconds = 0;
            Console.WriteLine($"After {seconds} seconds {percent_cream}% remains");
            while (percent_cream>50)
            {
                percent_cream *= 0.98;
                seconds++;
                Console.WriteLine($"After {seconds} seconds {percent_cream}% remains");
            }

            // Problem 6
            Console.WriteLine("Problem 6");
            Random random = new Random();
            int num_generated = 0;
            int num_range_10 = 0;
            int num_range_100 = 0;

            while (num_range_10 <= 10 && num_range_100 <= 10)
            {
                int random_num = random.Next(1, 101);
                num_generated++;
                if (0<random_num && random_num<11)
                {
                    num_range_10++;
                }
                else if (90<num && num<101)
                {
                    num_range_100++;
                }
            }
            Console.WriteLine($"{num_generated} numbers were generated");

            // Problem 7

            int num_found = 0;
            int n = 2;
            int[] numbers = new int[3];

            while (num_found<3)
            {
                double nth_triangular_number = (n * (n + 1)) / 2;
                bool is_perfect_square = Math.Sqrt(nth_triangular_number) % 1 == 0;
                if (is_perfect_square)
                {
                    numbers[num_found] = n;
                    num_found++;
                }
                n++;
            }
            Console.WriteLine($"The first three numbers are {String.Join(',', numbers)}");
        }
    }
}
