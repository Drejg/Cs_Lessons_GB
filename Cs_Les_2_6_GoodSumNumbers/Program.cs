using System;

namespace Cs_Les_2_6_GoodSumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //6. * Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.Хорошим называется число, которое делится на сумму своих цифр.

            IOclass IO = new IOclass();

            int count = 0;

            DateTime start = DateTime.Now;

            for (long i = 1; i <= 1000000000; i++)
            {
                if (CheckGoodNumber(i)) count++;
            }
            IO.Output($"Хороших чисел: {count}");
            //Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            IO.Output($"Время выполнения составило: {DateTime.Now - start}");
            IO.Pause();


        }

        private static bool CheckGoodNumber(long _i)
        {
            long RecursiveSum(long i)
            {
                if (i == 0)
                    return 0;
                else return RecursiveSum(i / 10) + i % 10;
            }
            return _i % RecursiveSum(_i) == 0;
        }

    }
}
