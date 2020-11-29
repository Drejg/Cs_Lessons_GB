using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Les_2_3_Summ_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            IOclass IO = new IOclass();

            long sum = 0;
            Int64.TryParse(IO.Input("Введите число"), out long num);

            while (num != 0)
            {
                if (num % 10 != 0 && num > 0) sum += num;
                Int64.TryParse(IO.Input("Введите число"), out num);
            }
            IO.Output($"Сумма всех нечетных положительных чисел: {sum}");
            IO.Pause();
        }
    }
}

