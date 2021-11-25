using System;

namespace SecretWord
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intialise the variables and secret word
            string menuOption;
            string guess;
            string secretWord = "Computer";

            do
            {
                // Output the menu
                DisplayMenu();

                // Ask the user for the menu number
                menuOption = Console.ReadLine();

                // Choose a task depending on the menu option 
                switch (menuOption)
                {
                    case "1":
                        // Change the secret word
                        secretWord = ChangeSecretWord();
                        break;
                    case "2":
                        // Guess the secret word
                        GuessSecretWord(secretWord);
                        break;
                    case "3":
                        // Quit the program
                        Quit();
                        break;
                    default:
                        Console.WriteLine("Invalid menu choice");
                        break;
                }
            }
            while (menuOption == "1" || menuOption == "2");
        }
        
        static void DisplayMenu()
        {
            Console.WriteLine("\nWelcome to the guessing program menu - choose your option:");
            Console.WriteLine("1 - Change the secret word");
            Console.WriteLine("2 - Make a guess");
            Console.WriteLine("3 - Quit");
        }
        
        static string ChangeSecretWord()
        {
            Console.WriteLine("What is the new secret word?");
            return Console.ReadLine();
        }
    
        static void GuessSecretWord(string secretWord)
        {
            Console.WriteLine("Guess the secret word:");
            string guess = Console.ReadLine();

            // Check whether the word entered was the secret word
            if (guess == secretWord)
            {
                Console.WriteLine("Well done - you have guessed the secret word!");
            }
            else
            {
                Console.WriteLine("Sorry, that is not the secret word");
            }
        }
    
        static void Quit()
        {
            Console.WriteLine("Thank you for playing secret word");
            Environment.Exit(0);
        }
    }
}
