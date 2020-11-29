using System;

namespace Cs_Les_2_1_Min_3_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Написать метод, возвращающий минимальное из трех чисел.
            IOclass IO = new IOclass();

            IO.Output($"Мнимальное число из трёх введеных: {MinNum(IO)}");

            IO.Pause();
        }

        private static int MinNum(IOclass IO)
        {
            Int32.TryParse(IO.Input("Введите число 1"), out int num1);
            Int32.TryParse(IO.Input("Введите число 2"), out int num2);
            Int32.TryParse(IO.Input("Введите число 3"), out int num3);

            int min = num1;

            min = min > num2 ? num2 : min;
            min = min > num3 ? num3 : min;

            return min;
        }

    }
}
