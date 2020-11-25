using System;

namespace Cs_Les_1_3_SQRT
{
    class Program
    {
        delegate double Coordinate_2(int _x1, int _y1, int _x2, int _y2);
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

            //б2) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            Coordinate_2 coordinate_2 = (_x1, _y1, _x2, _y2) => Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
            Console.WriteLine("\n");
            Console.WriteLine(coordinate_2(x1, y1, x2, y2).ToString("f2"));

            Console.ReadKey();
            //TODO Доделать в метод
            double Coordinate(int _x1, int _y1, int _x2, int _y2)
            {
                return Math.Sqrt(Math.Pow(_x2 - _x1, 2) + Math.Pow(_y2 - _y1, 2));
            }



        }
    }
}
