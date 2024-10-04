using System;
using Tyuiu.StoletovNA.Sprint1.Task2.V12.Lib;

namespace Tyuiu.StoletovNA.Sprint1.Task2.V12 {

    class Program {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Столетов Н. A. | ИИПб-24-2";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Организация ввода\\вывода в консольных приложениях                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Столетов Никита Андреевич | ИИПб-24-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int value, valueTwo, valueThree;
            Console.WriteLine("Введите длину параллелепипеда:");
            value = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите ширину параллелепипеда:");
            valueTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите высоту параллелепипеда:");
            valueThree = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CalculateParallelepipedVolume(value, valueTwo, valueThree));
            Console.ReadLine();


        }
    }
}
