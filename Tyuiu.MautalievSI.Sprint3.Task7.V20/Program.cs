using System;
using Tyuiu.MautalievSI.Sprint3.Task7.V20.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task7.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            Console.Title = "Спринт #3 | Выполнил: Мауталиев С.И. | Вариант #20";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Табулирование функции                               *");
            Console.WriteLine("* Задание #7                                                 *");
            Console.WriteLine("* Вариант #20                                                *");
            Console.WriteLine("* Выполнил: Мауталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Табулировать функцию на отрезке [-5; 5]                    *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            double[] res = ds.GetMassFunction(startValue, stopValue);

            int x = startValue;
            foreach (double y in res)
            {
                Console.WriteLine($"* f({x}) = {y}");
                x++;
            }

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}