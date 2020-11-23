using System;

namespace Cs_Les_1_3_SQRT
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
            Console.WriteLine("Введите значение x1:");
            int x1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y1:");
            int y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение x2:");
            int x2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение y2:");
            int y2 = Convert.ToInt32(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("\n");

            //а)  Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
            Console.WriteLine(r.ToString("f2"));

            Console.WriteLine("\n");

            //б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            Console.WriteLine(Coordinate(x1, y1, x2, y2).ToString("f2"));

            Console.ReadKey();
            //TODO Доделать в метод
            double Coordinate(int x1f, int y1f, int x2f, int y2f)
            {
                return Math.Sqrt(Math.Pow(x2f - x1f, 2) + Math.Pow(y2f - y1f, 2));
            }


        }
    }
}
