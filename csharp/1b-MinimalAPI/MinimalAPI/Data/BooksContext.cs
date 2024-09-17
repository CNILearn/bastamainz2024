using Microsoft.EntityFrameworkCore;
namespace MinimalAPI;

public class BooksContext(DbContextOptions<BooksContext> options) : DbContext(options)
{
    public DbSet<MinimalAPI.Book> Book => Set<Book>();
}
