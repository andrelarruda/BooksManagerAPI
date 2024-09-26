using BookManager.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookManager.API.Data
{
    public class BooksDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksDbContext(DbContextOptions<BooksDbContext> options) : base(options) {
        }
    }
}
