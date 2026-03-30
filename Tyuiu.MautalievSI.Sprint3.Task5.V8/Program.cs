using System;
using Tyuiu.MautalievSI.Sprint3.Task5.V8.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task5.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 12;

            Console.Title = "Спринт #3 | Выполнил: Мавталиев С.И. | Вариант #8";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Вложенные циклы                                      *");
            Console.WriteLine("* Задание #5                                                 *");
            Console.WriteLine("* Вариант #8                                                 *");
            Console.WriteLine("* Выполнил: Мавталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Вычислить двойную сумму                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine($"* i: {startValue1}..{stopValue1}");
            Console.WriteLine($"* k: {startValue2}..{stopValue2}");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            double result = ds.GetSumSumSeries(startValue1, startValue2, stopValue1, stopValue2);
            Console.WriteLine($"* y = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}