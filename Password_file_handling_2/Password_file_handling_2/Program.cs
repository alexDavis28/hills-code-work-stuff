﻿using System;
using System.IO;

namespace Password_file_handling_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"C:\Users\8m3xl\Desktop\passwords.txt";
            bool running = true;
            while (running)
            {
                Console.WriteLine("Enter 1 to store data, enter 2 to read data, enter 3 to quit.");
                switch (Console.ReadLine())
                {
                    case "1":
                        StoreData(filename);
                        break;
                    case "2":
                        if (!File.Exists(filename))
                        {
                            Console.WriteLine("File doesn't exist");
                        }
                        else
                        {
                            using (StreamReader sr = new StreamReader(filename, true))
                            {
                                string line;
                                while ((line = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(line);
                                }
                            }
                        }
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid input.");
                        break;
                }
            }
        }

        static void StoreData(string filename)
        {

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            StreamWriter sr = new StreamWriter(filename, true);
            sr.WriteLine(username);
            sr.WriteLine(password);
            sr.Close();

            Console.WriteLine("Data stored");
        }
    }
}
