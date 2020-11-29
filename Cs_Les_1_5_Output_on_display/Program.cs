using System;

namespace Cs_Les_1_5_Output_on_display
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            string fname = "Владимир";
            string lname = "Путин";
            string town = "Москва";

            Console.WriteLine($"Ваше имя и фамилия {fname} {lname}, вы живете в городе {town}.");

            //б) Сделать задание, только вывод организуйте в центре экрана
            Console.SetCursorPosition((Console.WindowWidth / 2) - 20, (Console.WindowHeight / 2) - 2);
            Console.WriteLine($"{fname} {lname}, город {town}.");
            
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
            string str = $"{lname} {fname}, город {town}.";

            Print(str, (Console.WindowWidth / 2) - 20, (Console.WindowHeight / 2) - 1);

            void Print(string _str, int x, int y)
            {
                Console.SetCursorPosition(x, y);
                Console.WriteLine(_str);
            }

            //6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

            LearnAdd LA = new LearnAdd();
            LA.Print($"город {town}, {fname} {lname}.", (Console.WindowWidth / 2) - 20, Console.WindowHeight / 2);
            LA.Pause();

        }
    }
}