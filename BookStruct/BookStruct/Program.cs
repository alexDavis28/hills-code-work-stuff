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


            // Second lesson

            Console.WriteLine("\n\nWriting and writing one book at a time:");

            WriteBook(Book1);
            DisplayBook(ReadBook());


            WriteBook(Book2);
            DisplayBook(ReadBook());

            Console.WriteLine("\n\nReading and writing an array of books:");

            WriteBookArray(BookArray);
            BookArray = ReadBookArray();
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

        static void WriteBook(Book book)
        {
            string documents_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string save_file_path = documents_path + @"\BookBinary\data.bin";

            using (BinaryWriter writer = new BinaryWriter(File.Open(save_file_path, FileMode.Create)))
            {
                writer.Write(book.title);
                writer.Write(book.author);
                writer.Write(book.genre);
                writer.Write(book.isbn);
                writer.Write(book.price);
                writer.Write(book.pages);
            }
        }

        static Book ReadBook()
        {
            string documents_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string save_file_path = documents_path + @"\BookBinary\data.bin";

            Book book = new Book();

            using (BinaryReader reader = new BinaryReader(File.Open(save_file_path, FileMode.Open)))
            {
                book.title = reader.ReadString();
                book.author = reader.ReadString();
                book.genre = reader.ReadString();
                book.isbn = reader.ReadInt64();
                book.price = reader.ReadDouble();
                book.pages = reader.ReadInt32();
            }
            return book;
        }
    
        static void WriteBookArray(Book[] books)
        {
            string documents_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string save_file_path = documents_path + @"\BookBinary\array_data.bin";

            var file = File.Create(save_file_path);
            file.Close();

            foreach (Book book in books)
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open(save_file_path, FileMode.Append)))
                {
                    writer.Write(book.title);
                    writer.Write(book.author);
                    writer.Write(book.genre);
                    writer.Write(book.isbn);
                    writer.Write(book.price);
                    writer.Write(book.pages);
                }
            }
        }

        static Book[] ReadBookArray()
        {
            string documents_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string save_file_path = documents_path + @"\BookBinary\array_data.bin";

            Book book1 = new Book();
            Book book2 = new Book();

            Book[] books = new Book[2] {book1, book2};

            using (BinaryReader reader = new BinaryReader(File.Open(save_file_path, FileMode.Open)))
            {
                for (int i = 0; i < books.Length; i++)
                {
                    {
                        books[i].title = reader.ReadString();
                        books[i].author = reader.ReadString();
                        books[i].genre = reader.ReadString();
                        books[i].isbn = reader.ReadInt64();
                        books[i].price = reader.ReadDouble();
                        books[i].pages = reader.ReadInt32();
                    }
                }
            }
            return books;
        }
    }
}