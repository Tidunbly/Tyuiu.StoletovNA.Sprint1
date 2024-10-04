using System;
using Tyuiu.StoletovNA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.StoletovNA.Sprint1.Task6.V12 {

    class Program {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Столетов Н. A. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПб-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Проверить, что последнее слово строки входит в нее еще раз.:            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            string value;
            Console.WriteLine("Введите строку:");
            value = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            if (ds.CheckLastWordRepetiton(value) == true)
            {
                Console.WriteLine("Последнее слово строки входит в неё как минимум ещё раз.");
            }
            else
            {
                Console.WriteLine("Последнее слово строки не входит в неё более 1 раза");
            }

        }
    }
}
