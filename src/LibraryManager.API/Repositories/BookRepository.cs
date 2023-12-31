using LibraryManager.API.Context;
using LibraryManager.API.Models;
using LibraryManager.API.Repositories.Interfaces;

namespace LibraryManager.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;           
        }
        
        public int Create(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();

            return book.Id;
        }
    }
}