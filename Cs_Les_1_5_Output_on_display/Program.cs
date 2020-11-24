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
            Console.SetCursorPosition((Console.WindowWidth / 2) - 20, Console.WindowHeight / 2);
            Console.WriteLine($"{fname} {lname}, город {town}.");
            //TODO Доделать два блока
            //в) *Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)

            //6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

            Console.ReadKey();
        }
    }
}