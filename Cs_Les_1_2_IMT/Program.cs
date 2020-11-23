using System;

namespace Cs_Les_1_2_IMT
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах
            Console.WriteLine("Укажите Ваш рост (в метрах):");
            double height = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

            Console.WriteLine("Укажите Ваш вес (в килограммах):");
            int weight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            double imt = weight / (height * height);

            Console.WriteLine($"Ваш индекс массы тела (ИМТ): {imt:.00}");

            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
