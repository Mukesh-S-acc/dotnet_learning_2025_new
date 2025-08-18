using DataAccess;
using Models;

namespace Business
{
    public class LibraryService
    {
        public BookStorage bookRepo = new BookStorage();

        public void AddBook(Book book)
        {

           if (book.AuthorId <= 0 || book.GenreId <= 0)
            {
                
                throw new Exception("AuthorId and GenreId must be valid");
            }

            bookRepo.InsertBook(book);
        }
    }
}
