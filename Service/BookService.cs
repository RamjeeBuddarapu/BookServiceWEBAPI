using BookServiceWEBAPI.Database;
using BookServiceWEBAPI.Entities;

namespace BookServiceWEBAPI.Service
{
    public class BookService : IBookService
    {
        private readonly MyContext _context;

        public BookService()
        {
            _context = new MyContext();
        }

        public void AddBook(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            try
            {
                List<Book> books = _context.Books.Where(b => b.Author == author).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByLang(string lang)
        {
            try
            {
                List<Book> books = _context.Books.Where(b => b.Lang == lang).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Book> GetBooksByYear(int year)
        {
            try
            {
                List<Book> books = _context.Books.Where(b => b.ReleaseDate.Year == year).ToList();
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditBook(Book book)
        {
            try
            {
                _context.Books.Update(book);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteBook(int bookId)
        {
            try
            {
                Book book = _context.Books.SingleOrDefault(x => x.BookID == bookId);
                if (book != null)
                {
                    _context.Books.Remove(book);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
