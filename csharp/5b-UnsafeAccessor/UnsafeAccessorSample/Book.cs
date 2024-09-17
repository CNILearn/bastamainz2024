namespace UnsafeAccessorSample;

public class Book(string title)
{
    private readonly string _title = title;
    public override string ToString() => _title;
}