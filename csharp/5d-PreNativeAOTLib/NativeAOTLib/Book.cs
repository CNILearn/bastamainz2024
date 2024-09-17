using System.Text.Json;
using System.Text.Json.Serialization;

namespace NativeAOTLib;

public class Book
{
    [JsonPropertyName("Id")]
    public int BookId { get; set; }
    public required string Title { get; set; }
    public string? Publisher { get; set; }
    public string? ISBN { get; set; }
}


public static class BookExtensions
{
    //private static JsonSerializerOptions options = new()
    //{
    //      TypeInfoResolver = BooksSerializerContext.Default
    //};
    public static string ToJson(this Book book)
    {
        string json = JsonSerializer.Serialize(book);
        // string json = JsonSerializer.Serialize(book, typeof(Book), BooksSerializerContext.Default);
        return json;
    }
}

//[JsonSerializable(typeof(Book))]
//internal partial class BooksSerializerContext : JsonSerializerContext
//{

//}
