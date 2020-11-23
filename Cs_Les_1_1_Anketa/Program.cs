using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Les_1_1_Anketa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
            Console.WriteLine("Назовите Ваше имя:");
            string fname = Console.ReadLine();

            Console.WriteLine("Назовите Вашу фамилию:");
            string lname = Console.ReadLine();
            
            Console.WriteLine("Укажите цифрами Ваш возраст (полных лет):");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите Ваш рост (в сантиметрах):");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Укажите Ваш вес (в килограммах):");
            int weight = Convert.ToInt32(Console.ReadLine());

            //а) используя склеивание;
            Console.WriteLine("\n");
            Console.WriteLine(fname + " " + lname + ", Ваш возраст: " + age + " лет, рост: " + height + " сантиметров, вес: " + weight + " килограмм.");

            //б) используя форматированный вывод;
            Console.WriteLine("\n");
            Console.WriteLine(String.Format("{0} {1}, Ваш возраст: {2} лет, рост: {3} сантиметров, вес: {4} килограмм.", fname, lname, age, height, weight));

            //в) *используя вывод со знаком $.
            Console.WriteLine("\n");
            Console.WriteLine($"{fname} {lname}, Ваш возраст: {age} лет, рост: {height} сантиметров, вес: {weight} килограмм.");

            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}
