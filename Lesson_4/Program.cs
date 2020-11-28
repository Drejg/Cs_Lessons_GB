using System;

class Program
{
    static void Main()
    {
        int value = 17;
        SetInt(value);
        Console.WriteLine(value);

        int valueRef = 17; // Обязаны присвоить значение
        SetIntRef(ref valueRef);
        Console.WriteLine(valueRef);

        int valueOut = 17;// Не Обязаны присвоить значение
        SetIntOut(out valueOut);
        Console.WriteLine(valueOut);

        int valueIn = 17;// Обязаны присвоить значение
        SetIntIn(in valueIn);
        Console.WriteLine(valueIn);

        //SetIntRef(ref _);
        SetIntOut(out _);
        //SetIntIn(in _);


        Complex complex = new Complex();
        complex.im = 4;
        complex.re = 4;

        Complex complex2 = new Complex();
        complex2.im = 2;
        complex2.re = 2;

        Console.WriteLine(complex.Minus(complex2).ToString());

        Console.ReadKey();
    }

    private static void SetInt(int value)
    {
        value = 18;
    }

    private static void SetIntRef(ref int value)
    {
        Console.WriteLine("-------------");
        value = 18;// Не Обязаны присвоить значение
    }

    private static void SetIntOut(out int value)
    {
        Console.WriteLine("-------------");
        value = 18;// Обязаны присвоить значение
    }

    private static void SetIntIn(in int value)
    {
        //value = 18;// Не можем присвоить значение
    }

    class Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex result = new Complex();

            result.im = x2.im + im;
            result.re = x2.re + re;

            return result;
        }

        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im - im;
            x3.re = x2.re - re;
            return x3;
        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }


}
