using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs_Les_2_2_Counts_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Написать метод подсчета количества цифр числа.
            IOclass IO = new IOclass();

            long.TryParse(IO.Input("Введите число"), out long num);
            IO.Output("\n");
            IO.Output($"Длина числа: {num} равна: {CountsDigits(num)}");
            IO.Pause();
        }

        private static int CountsDigits(long number)
        {
            if (number == 0)
                return 0;
            else return CountsDigits(number / 10) + 1;
        }
        
    }
}


