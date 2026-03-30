using System;
using Tyuiu.MautalievSI.Sprint3.Task4.V9.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task4.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.Title = "Спринт #3 | Выполнил: Мавталиев С.И. | Вариант #9";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Циклы                                                *");
            Console.WriteLine("* Задание #4                                                 *");
            Console.WriteLine("* Вариант #9                                                 *");
            Console.WriteLine("* Выполнил: Мавталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Вычислить произведение значений функции                   *");
            Console.WriteLine("* y = x / (cos(x) - x), x от -5 до 5 (x ≠ 0)                 *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine($"* start = {startValue}, stop = {stopValue}");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            double result = ds.Calculate(startValue, stopValue);
            Console.WriteLine($"* result = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}