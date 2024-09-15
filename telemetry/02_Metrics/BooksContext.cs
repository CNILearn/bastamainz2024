using Microsoft.EntityFrameworkCore;

namespace DiagnosticsSample;

public class BooksContext(DbContextOptions<BooksContext> options) : DbContext(options)
{
    public DbSet<Book> Books => Set<Book>();
}

public record Book(string Title, string Publisher, int BookId = default);
