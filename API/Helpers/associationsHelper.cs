using API.Data;
using API.Model;

namespace API.Helpers
{
    public class associationsHelper
    {
        public static Book getBookWithAssociations(Book book, BooksAPIContext _context)
        {
            if (book.Author == null)
            {
                book.Author = _context.Author.FirstOrDefault(author => author.Id == book.AuthorId);
            }
            book.Author.Book = new List<Book>();

            if (book.Category == null)
            {
                book.Category = _context.Category.FirstOrDefault(category => category.Id == book.CategoryId);
            }
            book.Category.Book = new List<Book>();

            return book;
        }

        public static Rating getRatingWithAssociations(Rating rating, BooksAPIContext _context)
        {
            if (rating.Book == null)
            {
                rating.Book = _context.Book.FirstOrDefault(book => book.Id == rating.BookId);
                rating.Book = getBookWithAssociations(rating.Book, _context);
            }
            rating.Book.Rating = new List<Rating>();

            if (rating.Reader == null)
            {
                rating.Reader = _context.Reader.FirstOrDefault(reader => reader.Id == rating.ReaderId);
            }
            rating.Reader.Rating = new List<Rating>();

            return rating;
        }
    }
}
