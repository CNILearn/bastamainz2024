namespace MinimalAPI;

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? Publisher { get; set; }
}
