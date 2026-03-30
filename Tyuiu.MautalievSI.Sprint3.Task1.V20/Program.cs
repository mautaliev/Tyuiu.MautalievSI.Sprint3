using System;
using Tyuiu.MautalievSI.Sprint3.Task1.V20.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task1.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 16;

            Console.Title = "Спринт #3 | Выполнил: Мавталиев С.И. | Вариант #20";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Циклы while                                          *");
            Console.WriteLine("* Задание #1                                                 *");
            Console.WriteLine("* Вариант #20                                                *");
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
            Console.WriteLine($"* S = {Math.Round(result, 4)}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}