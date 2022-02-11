using Microsoft.EntityFrameworkCore;

namespace BookAPI.Model
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Books> Books { get; set}
    }
}
