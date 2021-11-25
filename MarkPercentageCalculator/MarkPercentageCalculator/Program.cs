using System;

namespace MarkPercentageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            Console.WriteLine("How many students?");
            int students = int.Parse(Console.ReadLine());

            double[] marks = new double[students];
            double max_marks = 0;
            while (running)
            {
                Console.WriteLine("Enter 1 to input marks, enter 2 to calculate a percentage for each mark, enter 3 to find the average mark and enter q to exit the program.");
                string cmd = Console.ReadLine();
                switch (cmd)
                {
                    case "1":
                        Console.WriteLine("What's the maxium number of marks?");
                        max_marks = double.Parse(Console.ReadLine());
                        marks = InputMarks(max_marks, marks);
                        break;
                    case "2":
                        PercentMarks(marks, max_marks);
                        break;
                    case "3":
                        break;
                    case "q":
                        Console.WriteLine("Closing program");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            static double[] InputMarks(double max_marks, double[] marks)
            {

                for (int i = 0; i < students; i++)
                {
                    Console.WriteLine($"Enter result for student {i}");
                    marks[i] = double.Parse(Console.ReadLine());
                }

                return marks;
            }
        
            static void PercentMarks(double[] marks, double max_marks)
            {
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine($"Student {i}: {marks[i]}/{max_marks} = {(marks[i]/max_marks)*100}%");
                }
            }
        }
    }
}
