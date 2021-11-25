using System;

namespace TopFilms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] films = {"Arrival", "Annihlation", "Children of men", "Parasite", "Pacfic Rim"};

            foreach (string film in films)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine("");
            Array.Sort(films);
            Array.ForEach(films, Console.WriteLine);

            Console.WriteLine("");
            Array.Reverse(films);
            Array.ForEach(films, Console.WriteLine);

            Console.WriteLine("");
            films[films.Length-1] = "Up";
            Array.ForEach(films, Console.WriteLine);

        }
    }
}
