using DataAccess;
using Models;

namespace Business
{
    public class LibraryOps
    {
        public BookStorage bookRepo = new BookStorage();

        public void AddBook(Book book)
        {

           if (book.AuthorId <= 0 || book.GenreId <= 0 ||string.IsNullOrWhiteSpace(book.ISBN) ||  book.PublishedYear <= 0 || book.CopiesAvailable < 0)
            {
                
                Console.Write("input must be valid");
            
            }

            bookRepo.InsertBook(book);
        }
    }
}
