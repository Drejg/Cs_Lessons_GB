using System;

class Program
{
    static void Main()
    {
        View view = new View();
        Fib fib = new Fib(true);
        fib.Main();

        DateTime start = DateTime.Now;
        System.Threading.Thread.Sleep(20);// делаем паузу

        DateTime finish = DateTime.Now;
        Console.WriteLine(finish - start);

        view.Pause();
    }

    private static int MaxNumber(View view)
    {
        int max = 0;
        
        int firstNumber = view.GetInt("Введите первое число");
        
        int secondNumber = view.GetInt("Введите второе число");

        max = secondNumber > firstNumber ? secondNumber : firstNumber;


        if (firstNumber > secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }


        return max;
    }

    public void ExampleIf(View view)
    {
        // && и
        // || или
        if (false)
        {
            view.Print("No");
        }
        else if (true || false)
        {
            view.Print("Yes");
        }
        else
        {
            view.Print("MB");
        }
    }

    private static void GetDay(View view)
    {
        int day = view.GetInt("Введите день недели");

        switch (day)
        {
            case 1:
            {
                view.Print("Понедельник");
                break;
            }
            case 2:
            {
                view.Print("Вторник");
                break;
            }
            case 3:
            {
                view.Print("Среда");
                break;
            }
            case 4:
            {
                view.Print("Четверг");
                break;
            }
            case 5:
            {
                view.Print("Пятница");
                break;
            }
            case 6:
            case 7:
            {
                view.Print("Суббота или воскресенье");
                break;
            }
            default:
            {
                view.Print("Нет такого");
                break;
            }
        }

        //if (day == 1)
        //{
        //    view.Print("Понедельник");
        //}
        //else if (day == 2)
        //{
        //    view.Print("Вторник");
        //}
        //else if (day == 3)
        //{
        //    view.Print("Среда");
        //}
        //else if (day == 4)
        //{
        //    view.Print("Четверг");
        //}
        //else if (day == 5)
        //{
        //    view.Print("Пятница");
        //}
        //else if (day > 5 && day <= 7)
        //{
        //    view.Print("Суббота или воскресенье");
        //}
        //else
        //{
        //    view.Print("Нет такого");
        //}
    }
    
    public static void LevelSelect(View view)
    {
        int level = view.GetInt("Выберете уровень сложности");

        switch (level)
        {
            case (int)LevelSelection.Easy:
                view.Print("10 zombi");
                break;
            case (int)LevelSelection.Normal:
                view.Print("20 zombi");
                break;
            case (int)LevelSelection.Hard:
                view.Print("50 zombi");
                break;
            default:
                view.Print("0 zombi");
                break;
        }
    }

    public static void GetBeer(View view)
    {
        int age = view.GetInt("Сколько вам лет?");
        if (age < 18)
        {
            GetBeer(view);
        }
        else
        {
            view.Print("Вот ваше пиво, сэр");
        }
    }

    public static void ExampleFor(View view)
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i == 5)
            {
                //continue;
                //break;
                //return;
            }
            view.Print($"{i}) Roman");
        }


        view.Print("--------------");
        view.Print("Roman");
        view.Print("Roman");
        view.Print("Roman");
        view.Print("Roman");
        view.Print("Roman");
        view.Print("Roman");
        view.Print("Roman");
        view.Print("Roman");
        view.Print("Roman");
        view.Print("Roman");
    }

    public static void ExampleWhile(View view)
    {
        int i = 1;
        while (i >= 10)
        {
            view.Print($"{i}) Roman");
            i++;
        }

        i = 1;

        do
        {
            view.Print($"{i}) Ivan");
            i++;
        } while (i >= 10);
    }
}
