using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number;
            string isPlaying = "y";
            bool isGuessing;
            int guess;
            string input;
            bool valid_input;
            int num_guesses;

            do
            {
                number = random.Next(100) + 1;
                isGuessing = true;
                num_guesses = 0;
                while (isGuessing)
                {
                    Console.WriteLine("?: ");
                    input = Console.ReadLine();
                    valid_input = int.TryParse(input, out guess);
                    if (valid_input)
                    {
                        num_guesses++;
                        if (guess == number)
                        {
                            Console.WriteLine("Well done!");
                            isGuessing = false;
                        }
                        else if(guess > number)
                        {
                            Console.WriteLine("Too high");
                        }
                        else if(guess < number)
                        {
                            Console.WriteLine("Too low");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not a valid input");
                    }
                }
                Console.WriteLine($"You took {num_guesses} tries to get the correct answer.");
                Console.WriteLine("Play again? y/n: ");
                isPlaying = Console.ReadLine();

            } while (isPlaying.ToLower()=="y");
        }
    }
}
