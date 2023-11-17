using BookServiceWEBAPI.Entities;

namespace BookServiceWEBAPI.Service
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();
        List<Book> GetBooksByAuthor(string author);
        List<Book> GetBooksByLang(string lang);
        List<Book> GetBooksByYear(int year);
        void EditBook(Book book);
        void DeleteBook(int bookId);
    }
}
