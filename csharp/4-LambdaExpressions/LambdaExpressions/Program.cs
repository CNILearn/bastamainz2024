Func<int, int, int> d1 = int (int x, int y) => x + y;

int result1 = d1(38, 4);
Console.WriteLine(result1);

Delegate d2 = int (int x, int y) => x + y;

dynamic? result2 = d2.DynamicInvoke(33, 9);
Console.WriteLine(result2);

// default lambda parameters
var d3 = (int x = 38, int y = 4) => x + y;
int result3 = d3();
Console.WriteLine(result3);
