using System;
using System.IO;

namespace BookStruct
{
    struct Book
    {
        // Declare the fields for the Books struct
        public string title;
        public string author;
        public string genre;
        public long isbn; // long is a 64-bit integer for the 13 digit isbn
        public double price;
        public int pages;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare Book1 of type Book
            Book Book1 = new Book();

            // Assign values to the Book1 object
            Book1.title = "A promised land";
            Book1.author = "Barack Obama";
            Book1.genre = "Politics";
            Book1.isbn = 9780241491515;
            Book1.price = 17.50;
            Book1.pages = 768;

            // Declare Book2 of type Book
            Book Book2 = new Book();

            Book2.title = "Dune";
            Book2.author = "Frank Herbert";
            Book2.genre = "Science-fiction";
            Book2.isbn = 0340960191;
            Book2.price = 9.99;
            Book2.pages = 592;

            Book[] BookArray = new Book[2] {Book1, Book2};

            foreach (Book book in BookArray)
            {
                DisplayBook(book);
            }

        }

        static void DisplayBook(Book book)
        {
            Console.WriteLine($"\nTitle: {book.title}");
            Console.WriteLine($"Author: {book.author}");
            Console.WriteLine($"Genre: {book.genre}");
            Console.WriteLine($"ISBN: {book.isbn}");
            Console.WriteLine($"Price: {book.price}");
            Console.WriteLine($"Pages: {book.pages}");
        }
    }
}