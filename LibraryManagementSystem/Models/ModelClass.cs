namespace Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    }


    public class Genre
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string ISBN { get; set; }
        public int PublishedYear { get; set;}
        public int CopiesAvailable {get; set;}

    }

   
    public class Member
    {
        public int MemberId { get; set; }
        public string Name {get; set; }
        public string Email {get; set;}
        public string Phone { get; set;}
        public DateTime JoinDate {get; set;}
    }
    public class BorrowRecord
    {
        public int BorrowId { get; set;}
        public int MemberId { get; set;}
        public int BookId {get; set;}
        public DateTime BorrowDate {get; set;}
        public DateTime ReturnDate { get; set;} 
    }
}
