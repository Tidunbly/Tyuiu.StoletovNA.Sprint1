using System;
using Tyuiu.StoletovNA.Sprint1.Task3.V8.Lib;

namespace Tyuiu.StoletovNA.Sprint1.Task3.V8 {

    class Program {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Столетов Н. A. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПб-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double startAmount, persent, timedays;

            Console.WriteLine("Введите величину вклада:");
            startAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите срок вклада:");
            timedays = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите процентную ставку:");
            persent = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.IncomeAmount(startAmount, persent, timedays));
            Console.ReadLine();

        }
    }
}
