
int x = 1;

// pass by value
One(x);  // pass by value
Console.WriteLine($"after one: {x}");

// pass by reference
// Two(x); // error, must use ref
Two(ref x);
Console.WriteLine($"after two: {x}");

// pass by readonly reference
Three(x);  // warning, should use in or ref
Three(ref x); 
Three(in x);
// Three(3);  // this is not possible with readonly ref

// pass by in reference
Four(x);
Four(ref x);  // warning - consider using in
Four(in x);
Four(4); // this is ok with in (rvalue - constant, expression...)

void One(int x)
{
    Console.WriteLine($"One {x}");
    x = 2;
}

void Two(ref int x)
{
    Console.WriteLine($"Two {x}");
    x = 3;
}

// lvalue only
void Three(ref readonly int x)
{
    Console.WriteLine($"Three, {x}");
    // x = 4; cannot assign - readonly variable
}

// lvalue or rvalue!
// may create a temporary copy of the value if the compiler thinks it's necessary
void Four(in int x)
{
    // x = 5; cannot assign - readonly variable
}