using System;

public class LearnAdd
{
    public void Print(string _str, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(_str);
    }

    public void Pause()
    {
        Console.ReadKey();
    }
}
