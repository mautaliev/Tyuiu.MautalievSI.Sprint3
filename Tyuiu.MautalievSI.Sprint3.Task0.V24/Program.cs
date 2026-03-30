using System;
using Tyuiu.MautalievSI.Sprint3.Task0.V24.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task0.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 7;

            Console.Title = "Спринт #3 | Выполнил: Мавталиев С.И. | Вариант #24";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Циклы                                                *");
            Console.WriteLine("* Задание #0                                                 *");
            Console.WriteLine("* Вариант #24                                                *");
            Console.WriteLine("* Выполнил: Мавталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет произведение ряда   *");
            Console.WriteLine("* по формуле при x = 5                                       *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine($"* x = {value}");
            Console.WriteLine($"* start = {startValue}, stop = {stopValue}");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            double result = ds.GetMultiplySeries(value, startValue, stopValue);
            Console.WriteLine($"* p = {Math.Round(result, 4)}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}