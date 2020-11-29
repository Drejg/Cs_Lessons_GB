using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Les_2_4_LoginPass
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
            //(Логин: root, Password: GeekBrains).
            //Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
            //С помощью цикла do while ограничить ввод пароля тремя попытками.

            IOclass IO = new IOclass();

            if (Attemps(IO))
                IO.Output("Вы успешно авторизовались");
            else IO.Output("К сожалению логин/пароль не подошел");

            IO.Pause();
        }

        private static bool Attemps(IOclass IO)
        {
            Verif ver = new Verif();
            int n = 3;
            do
            {
                IO.Output($"У Вас отсалось {n} попытки!");
                n--;
                string login = IO.Input("Введите логин");
                string pass = IO.Input("Введите пароль");
                if (ver.Check(login, pass)) return true;
            }
            while (n > 0);
            return false;
        }
    }
}
