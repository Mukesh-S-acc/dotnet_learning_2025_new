using Models;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class BookStorage
    {
        private static string connection =
            "Server=mazenet-test; Database=LibraryManagement;Trusted_Connection=True;";


        public void InsertBook(Book book)
        {
            using (SqlConnection connect = new SqlConnection(connection))
            {
                 connect.Open();

               string query = @"insert into books 
                                (title, authorid, genreid, isbn, publishedyear, copiesavailable) 

                                values (@title, @aid, @gid, @isbn, @year, @copies)";

               
                
                SqlCommand cd = new SqlCommand(query, connect);

                cd.Parameters.AddWithValue("@title", book.Title);
                cd.Parameters.AddWithValue("@aid", book.AuthorId);
                cd.Parameters.AddWithValue("@gid", book.GenreId);
                cd.Parameters.AddWithValue("@isbn", book.ISBN);
                cd.Parameters.AddWithValue("@year", book.PublishedYear);
                cd.Parameters.AddWithValue("@copies", book.CopiesAvailable);

                cd.ExecuteNonQuery();
            }
        }
    }
}
