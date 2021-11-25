using System;

namespace Space_name
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First name: ");
            string first_name = Console.ReadLine();
            Console.WriteLine("Last name: ");
            string last_name = Console.ReadLine();
            Console.WriteLine("Town you were born in: ");
            string town = Console.ReadLine();
            Console.WriteLine("Month you were born in: ");
            string month = Console.ReadLine();

            string space_first_name = last_name.Substring(0, 3) + first_name.Substring(0, 2);
            string space_last_name = town.Substring(0, 3) + month.Substring(month.Length - 2);
            space_first_name = space_first_name.ToLower();
            space_last_name = space_last_name.ToLower();

            Console.WriteLine("Your space name is " + space_first_name + " " + space_last_name);

        }
    }
}
