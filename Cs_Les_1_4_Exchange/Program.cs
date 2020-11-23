using System;

namespace Cs_Les_1_4_Exchange
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу обмена значениями двух переменных.
            Console.WriteLine("Введите число X:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите число Y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine($"В переменой X: {x}, в Y: {y}");
            Console.WriteLine("\n");

            //а) с использованием третьей переменной;
            int tmp = x;
            x = y;
            y = tmp;

            Console.WriteLine($"Вжух... и в переменой X теперь: {x}, а в Y: {y}");
            Console.WriteLine("\n");

            //б) *без использования третьей переменной.
            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine($"Вжух ещё раз... и в переменой X теперь: {x}, а в Y: {y}");


            Console.WriteLine("\n");
            Console.ReadKey();


        }
    }
}
