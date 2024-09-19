using Microsoft.EntityFrameworkCore;

namespace DiagnosticsSample;

public class Runner(IDbContextFactory<BooksContext> contextFactory, ILogger<Runner> logger)
{
    private readonly ILogger _logger = logger;

    public void InfoMessage1()
    {
        _logger.LogInformation("Sample1");
    }

    public void InfoMessage2()
    {
        _logger.GameStarted("a game");
    }

    public void ErrorMessage()
    {
        _logger.GameIdNotFound("4711");
    }

    public void Foo()
    {

        _logger.LogInformation("foo");
        Bar();
    }

    private void Bar()
    {
        _logger.LogInformation("Bar");
    }

    public void AddARecord()
    {
        using var context = contextFactory.CreateDbContext();
        context.Database.EnsureCreated();
        context.Books.Add(new Book($"title {Random.Shared.Next(2000)}", "sample pub"));
        context.SaveChanges();
    }
}
