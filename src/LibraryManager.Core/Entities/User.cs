using LibraryManager.Core.Entities;

namespace LibraryManager.Core.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}