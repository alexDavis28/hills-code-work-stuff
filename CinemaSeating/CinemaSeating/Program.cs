using System;

namespace CinemaSeating
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] seats = new string[10, 18];
            for (int row = 0; row < seats.GetLength(0); row++)
            {
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    seats[row, col] = "-";
                }
            }

            bool running = true;

            int num_children = 0;
            int num_adults = 0;

            while (running)
            {
                DisplaySeats(seats);

                Console.WriteLine("Enter 1 to book a single seat, enter 2 to book several seats.");

                string input = Console.ReadLine();

                if (input.ToLower() == "1")
                {
                    Console.WriteLine("On which row would you like to book a seat (A-J)?");
                    string[] row_names = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                    int row_int = Array.IndexOf(row_names, Console.ReadLine().ToUpper());

                    Console.WriteLine("Which seat number do you want to book? (0-17)");
                    int seat_num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Adult or child ticket?");
                    string ticket_type = Console.ReadLine().ToLower().Substring(0, 1);
                    if (seats[row_int, seat_num] == "-")
                    {
                        if (ticket_type == "a")
                        {
                            num_adults++;
                        }
                        else if (ticket_type == "c")
                        {
                            num_children++;
                        }
                        seats[row_int, seat_num] = ticket_type;
                    }
                    else
                    {
                        Console.WriteLine("That seat is already booked.");
                    }

                }
                else if (input=="2")
                {
                    Console.WriteLine("Which row would you like to book seats on? (A-J)");
                    string[] row_names = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
                    int row_int = Array.IndexOf(row_names, Console.ReadLine().ToUpper());

                    Console.WriteLine("How many seats would you like to book");
                    int num_seats_to_book = int.Parse(Console.ReadLine());

                    Console.WriteLine("What is the number of the leftmost seat you want to book? (0-17)");
                    int start_seat = int.Parse(Console.ReadLine());

                    if (start_seat+num_seats_to_book > seats.GetLength(1))
                    {
                        Console.WriteLine("Not enough space for those seats");
                        continue;
                    }

                    bool all_seats_clear = true;

                    for (int i = start_seat; i < start_seat+num_seats_to_book; i++)
                    {
                        if (seats[row_int, i] != "-")
                        {
                            all_seats_clear = false;
                        }
                    }

                    if (!all_seats_clear)
                    {
                        Console.WriteLine("Some of those seats are booked");
                    }
                    else
                    {
                        for (int i = start_seat; i < start_seat + num_seats_to_book; i++)
                        {
                            Console.WriteLine($"Seat {i}, Row {row_names[row_int]}: Adult or child ticket (a/c)?");
                            string ticket_type = Console.ReadLine().ToLower();
                            seats[row_int, i] = ticket_type;
                            if (ticket_type=="a")
                            {
                                num_adults++;
                            }
                            else if (ticket_type=="c")
                            {
                                num_children++;
                            }
                        }
                    }

                }
                else
                {
                    running = false;
                    Console.WriteLine($"There are {num_adults} adult tickets booked, {num_children} child tickets booked and {180-num_children-num_adults} seats left");
                }
            }
        }


        static void DisplaySeats(string[,] seats)
        {

            string[] row_names = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

            //Console.WriteLine("   0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18");

            for (int row = 0; row < seats.GetLength(0); row++)
            {
                Console.Write($"{row_names[row]}: ");
                for (int col = 0; col < seats.GetLength(1); col++)
                {
                    Console.Write($"{seats[row, col]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}