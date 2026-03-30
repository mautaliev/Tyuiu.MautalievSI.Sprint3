using System;
using Tyuiu.MautalievSI.Sprint3.Task6.V26.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task6.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = 15;
            int stopValue = 22;

            Console.Title = "Спринт #3 | Выполнил: Мауталиев С.И. | Вариант #26";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Циклы                                                *");
            Console.WriteLine("* Задание #6                                                 *");
            Console.WriteLine("* Вариант #26                                                *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Найти количество всех делителей среди чисел               *");
            Console.WriteLine("* на отрезке [15, 22]                                        *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine($"* startValue = {startValue}");
            Console.WriteLine($"* stopValue  = {stopValue}");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            int result = ds.GetSumTheDivisors(startValue, stopValue);
            Console.WriteLine($"* Количество делителей = {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}