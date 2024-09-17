using System.Runtime.CompilerServices;
using UnsafeAccessorSample;

Book b1 = new("Pragmatic Microservices");
Console.WriteLine(b1);

// set the private field using this unsafe accessor
ChangeIt.GetTitle(b1) = "Pragmatic Microservices with C# and Azure";
Console.WriteLine(b1);

internal class ChangeIt
{
    [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "_title")]
    public extern static ref string GetTitle(Book @this);
}