// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using System.Runtime.CompilerServices;

var summary = BenchmarkRunner.Run<Runner>();


[InlineArray(4)]
public struct Buffer
{
    private int _x;
}

[MemoryDiagnoser]
public class Runner
{
    [Benchmark]
    public void UseNormalArray()
    {
        var buffer = new int[4];
        for (var i = 0; i < buffer.Length; i++)
        {
            buffer[i] = i;
        }
        int result = 0;
        foreach (var i in buffer)
        {
            result += i;
        }
        // Console.WriteLine(result);
    }

    [Benchmark]
    public void UseBuffer()
    {
        Buffer buffer = new();
        for (var i = 0; i < 4; i++)
        {
            buffer[i] = i;
        }
        int result = 0;
        foreach (var i in buffer)
        {
            result += i;
        }
       // Console.WriteLine(result);
    }
}