using System;

namespace Cs_Les_2_8_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //7.
            Console.WriteLine("Введите первое число");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            //a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a < b);
            PrintAB(a, b);
            Console.WriteLine("\n");
            //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            Console.WriteLine($"Сумма чисел: {SumAB(a, b)}");

            Console.ReadKey();

        }

        private static void PrintAB(int _a, int _b)
        {
            if (_a <= _b)
            {
                Console.WriteLine(_a);
                PrintAB(_a + 1, _b);
            }
            return;
        }

        private static int SumAB(int _a, int _b)
        {
            if (_a <= _b)
            {
                return SumAB(_a + 1, _b) + _a;
            }
            return 0;
        }

    }
}
