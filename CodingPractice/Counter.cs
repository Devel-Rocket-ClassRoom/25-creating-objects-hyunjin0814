using System;

class Counter
{
    public int Count = 0;

    public void Increment()
    {
        Count++;
        Console.WriteLine($"현재 카운트: {Count}");
    }

    public void Reset()
    {
        Count = 0;
        Console.WriteLine("카운트가 초기화되었습니다.");
    }
}