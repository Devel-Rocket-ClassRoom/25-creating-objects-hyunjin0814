using System;

class Calculator
{
    public void Add(int x, int y)
    {
        int sum = x + y;
        Console.WriteLine($"합계: {sum}");
    }

    public void Multiply(int x, int y)
    {
        int multiply = x * y;
        Console.WriteLine($"곱: {multiply}");
    }
}