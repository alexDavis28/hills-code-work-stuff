using System;

namespace PaswordGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "password";
            int i = 0;
            string guess = "";
            while (i<3)
            {
                Console.Write("Enter password: ");
                guess = Console.ReadLine();
                if (guess==password)
                {
                    Console.WriteLine("Correct password");
                    i = 3;
                }
                else
                {
                    Console.WriteLine("Incorrect password");
                    i++;
                }
            }
            if (guess==password)
            {
                Console.WriteLine("Unlocked");
            }
            else
            {
                Console.WriteLine("Locked due to too many wrong attempts");
            }
        }
    }
}
