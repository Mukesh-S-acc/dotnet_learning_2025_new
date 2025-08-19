using Business;
using Models;
using System;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryOps op = new LibraryOps();

            Console.WriteLine("Add  a New Book");
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Author id: ");
            int authorId = int.Parse(Console.ReadLine());

            Console.Write("Enter Author Country: ");
            string country = Console.ReadLine();

            Console.Write("Enter Genre id: ");
            int genreId = int.Parse( Console.ReadLine());

            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();

            Console.Write("Enter Published Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Enter Copies Available: ");
            int copies = int.Parse(Console.ReadLine());

            Book book = new Book { Title = title, AuthorId  = authorId, GenreId = genreId, ISBN = isbn, PublishedYear = year, CopiesAvailable = copies };

            
            op.AddBook(book);
           

        }
    }
}
