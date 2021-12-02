using System;
using System.IO;

namespace FantasyFootball
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename = @"C:\Users\8m3xl\Desktop\footballers.txt";


            // While loop controls menu
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter 1 to store footballer, enter 2 to view team, enter 3 to calculate team value, enter 4 to quit.");
                switch (Console.ReadLine())
                {
                    case "1":
                        StoreFootballer(filename);
                        break;
                    case "2":
                        ViewTeam(filename);
                        break;
                    case "3":
                        TeamValue(filename);
                        break;
                    case "4":
                        Console.WriteLine("Quitting");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
        static void StoreFootballer(string filename)
        {
            // Check if there are already 5 players added
            string[] lines = ReadFile(filename);
            if (lines.Length==5)
            {
                Console.WriteLine("Too many players to add another");
            }
            else
            {
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Goals scored:");
                string goals = Console.ReadLine();
                Console.WriteLine("Number of yellow cards: ");
                string yellow_cards = Console.ReadLine();
                Console.WriteLine("Number of red cards");
                string red_cards = Console.ReadLine();

                // Format and store the player data

                string data = $"\n{name},{goals},{yellow_cards},{red_cards}";

                File.AppendAllText(filename, data);
            }

            

        }
        static void ViewTeam(string filename)
        {
            string[] lines = ReadFile(filename);
            foreach (string line in lines)
            {
                string[] player = line.Split(','); // Split the string by commas to seperate the value
                Console.WriteLine($"{player[0]} - Goals scored: {player[1]} - Yellow cards: {player[2]} - Red cards: {player[3]}"); // Format and print the player data
            }

        }
        static void TeamValue(string filename)
        {
            int score = 0;
            string[] lines = ReadFile(filename);
            // Iterate through every line in the file and adjust the team score
            foreach (string line in lines)
            {
                string[] player = line.Split(',');
                score += 10 * int.Parse(player[1]);
                score -= 2 * int.Parse(player[2]);
                score -= 5 * int.Parse(player[3]);
            }
            Console.WriteLine($"Team score is: {score}");
        }

        static string[] ReadFile(string filename)
        {
            string[] lines;
            lines = File.ReadAllLines(filename);
            return lines;
        }
    }
}
