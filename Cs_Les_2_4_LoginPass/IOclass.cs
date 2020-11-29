using System;

class IOclass
{
    public void Output(object _value)
    {
        Console.WriteLine(_value);
    }

    public string Input()
    {
        return Console.ReadLine();
    }
    public string Input(string _str)
    {
        Console.WriteLine(_str);
        return Console.ReadLine();
    }

    public void Pause()
    {
        Console.ReadKey();
    }
}
