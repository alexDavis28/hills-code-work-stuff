using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialise the variables
            double price = 11.50;
            string ticketType;
            string extras = "None";
            Boolean member = false;

            // Ask user for the ticket type
            Console.WriteLine("Enter the ticket type: ");
            ticketType = Console.ReadLine();

            // Ask user if the ticket holder is a member
            Console.WriteLine("Is the ticket holder a member? (true or false) ");
            member = Convert.ToBoolean(Console.ReadLine());

            // Calculate the price depending on the ticket type and membership
            if (ticketType == "Infant")
            {
                // Infants go free
                price = 0.0;
            }
            // ??? complete the else if statements here

            else if ( (ticketType == "Student" || ticketType == "Senior") && member)
            {
                price *= 0.8;
                price *= 0.9;
                extras = "Popcorn and Premier Seats";
            }

            else if (ticketType == "Student" || ticketType == "Senior")
            {
                price *= 0.8;
            }

            else if (member)
            {
                price *= 0.9;
                extras = "Premier seats";
            }

            else
            {
                // Set the ticket type to Adult
                ticketType = "Adult";
            }

            // Output the ticket details
            Console.WriteLine("Ticket type: " + ticketType);
            Console.WriteLine("Membership: " + member);
            Console.WriteLine("Ticket cost: £" + Math.Round(price, 2).ToString("0.00"));
            Console.WriteLine("Extras: " + extras);
        }

        /* TASKS:
        1. Add an else if statement that checks if the ticket holder is a member:
            - If they are a member, reduce the ticket price by 10%
            - Assign the string “Premier seats” to the extras variable
        2. Add an else if statement that checks if the ticket type is “Student” or “Senior”:
            - Hint: use two of the pipe symbols || for the Logical OR operator
            - This should reduce the ticket price by 20%
        3. Add a nested if statement to the previous else if statement
            - If the ticket holder is a member as well as a Student or Senior, assign “Popcorn” as an extra  

        Extension: Try to program Task 3 using an Logical AND operator instead of a nested if statement
        */
    }
}
