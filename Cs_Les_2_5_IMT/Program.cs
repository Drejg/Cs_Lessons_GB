using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Les_2_5_IMT
{
    class Program
    {
        static void Main(string[] args)
        {
            //5.
            //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;

            IOclass IO = new IOclass();

            IO.Output("Укажите Ваш рост (в метрах):");
            double height = IO.InDouble();
            Console.WriteLine("Укажите Ваш вес (в килограммах):");
            double weight = IO.InInt();

            IO.Output("\n");

            double imt = (double)weight / (height * height);
            IO.Output($"Ваш индекс массы тела (ИМТ): {imt:.00}");

            if (imt < 18.5)
                IO.Output("Рекомендуем вам больше есть!");
            else if (imt > 25)
                IO.Output("Рекомендуем вам меньше есть!");
            else IO.Output("Еште сколько хотите!");

            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            if (imt >= 18.5 && imt < 25)
                IO.Output($"У вас всё отлично");
            else if (imt < 18.5)
            {
                IO.Output($"Вам необходимо набрать {(18.5 * height * height) - weight:.00} кг.");
            }
            else
                IO.Output($"Вам необходимо сбросить {weight - (25 * height * height):.00} кг.");

            IO.Pause();

            //ИМТ >= 18.5 И < 25:	Нормальный вес
        }
    }
}






