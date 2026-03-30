using System;
using Tyuiu.MautalievSI.Sprint3.Task2.V19.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 10;

            Console.Title = "Спринт #3 | Выполнил: Мавталиев С.И. | Вариант #19";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Циклы do...while                                     *");
            Console.WriteLine("* Задание #2                                                 *");
            Console.WriteLine("* Вариант #19                                                *");
            Console.WriteLine("* Выполнил: Мавталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Вычислить сумму ряда по формуле                            *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine($"* start = {startValue}, stop = {stopValue}");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            double result = ds.GetSumSeries(startValue, stopValue);
            Console.WriteLine($"* S = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}