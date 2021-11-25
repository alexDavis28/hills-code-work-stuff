using System;

namespace Subjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of subjects");
            int num_subjects = int.Parse(Console.ReadLine());

            string[] subjects = new string[num_subjects];

            for (int i = 0; i < num_subjects; i++)
            {
                Console.WriteLine($"Enter subject {i+1}: ");
                subjects[i] = Console.ReadLine();
            }


            bool checking = true;

            int subject_to_change = 0;

            while (checking)
            {
                Console.WriteLine("\nYou chose the following subjects: ");
                for (int i = 0; i < subjects.Length; i++)
                {
                    Console.WriteLine($"{i+1}: {subjects[i]}");
                }
                Console.WriteLine("If you would like to change any subject, enter its number then what you want to change it to. If you are ok with your choices, enter 0.");

                subject_to_change = int.Parse(Console.ReadLine());
                if (subject_to_change == 0)
                {
                    checking = false;
                }
                else if (subject_to_change>subjects.Length)
                {
                    Console.WriteLine("That's not a valid number");
                }
                else
                {
                    Console.WriteLine("\nWhat would you like the change that subject to: ");
                    subjects[subject_to_change-1] = Console.ReadLine();
                }
            }

            Console.WriteLine("\nYour final subject choices: ");
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {subjects[i]}");
            }


        }
    }
}
