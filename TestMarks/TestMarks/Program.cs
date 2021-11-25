using System;

namespace TestMarks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialise a 2D array for the test marks of Paper 1 and Paper 2

            Console.WriteLine("How many tests: ");
            int num_tests = int.Parse(Console.ReadLine());
            Console.WriteLine("How many students");
            int num_students = int.Parse(Console.ReadLine());

            int[,] marks = new int[num_tests, num_students];

            for (int row = 0; row < marks.GetLength(0); row++)
            {
                for (int col = 0; col < marks.GetLength(1); col++)
                {
                    Console.WriteLine($"Result for test #{row + 1}, student #{col}: ");
                    marks[row, col] = int.Parse(Console.ReadLine());
                }
            }


            bool running = true;
            while (running)
            {
                // Traverse the marks 2D array to output all the elements
                for (int row = 0; row < marks.GetLength(0); row++)
                {
                    for (int col = 0; col < marks.GetLength(1); col++)
                    {
                        // Output the test mark
                        Console.WriteLine($"Test #{row + 1}, Student #{col}: {marks[row, col]} marks");
                    }
                    // Create a new empty line after all the marks of a paper has been output
                    Console.WriteLine();
                }

                Console.WriteLine("Enter 1 to change a specific mark\nEnter 2 to change all the marks\nEnter any other input to end program");

                string user_input = Console.ReadLine();

                switch (user_input)
                {
                    case "1":
                        Console.WriteLine("Enter test number: ");
                        int test_num = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter student number: ");
                        int student_num = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Enter value to change student #{student_num}'s result for test #{test_num} to: ");
                        int new_value = int.Parse(Console.ReadLine());

                        marks[test_num - 1, student_num] = new_value;

                        Console.WriteLine("Value changed.\n");

                        break;

                    case "2":
                        for (int row = 0; row < marks.GetLength(0); row++)
                        {
                            for (int col = 0; col < marks.GetLength(1); col++)
                            {
                                Console.WriteLine($"Result for test #{row+1}, student #{col}: ");
                                marks[row, col] = int.Parse(Console.ReadLine());
                            }
                        }
                        Console.WriteLine("All values changed\n");
                        break;

                    default:
                        running = false;
                        Console.WriteLine("\nClosing Program");
                        break;
                }

            }

            /* TASKS:
            - Output a clear message with the student number (0-5) and the paper number (1-2)
            - Allow the user to replace a single test mark then output the updated 2D array
            - Allow the user to replace all of the test marks using another nested for loop

            Challenge: Ask the user for the number of papers and students to submit marks for. 
            The program should create an empty 2D array and then ask the user for each mark.
            */
        }
    }
}
