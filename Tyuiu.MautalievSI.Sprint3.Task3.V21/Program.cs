using System;
using Tyuiu.MautalievSI.Sprint3.Task3.V21.Lib;

namespace Tyuiu.MautalievSI.Sprint3.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string value = "f3g5ht g4j 34kg4";
            char item = 'e';

            Console.Title = "Спринт #3 | Выполнил: Мавталиев С.И. | Вариант #21";
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* Спринт #3                                                  *");
            Console.WriteLine("* Тема: Цикл foreach                                         *");
            Console.WriteLine("* Задание #3                                                 *");
            Console.WriteLine("* Вариант #21                                                *");
            Console.WriteLine("* Выполнил: Мавталиев С.И.                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                   *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву e           *");
            Console.WriteLine("* в строке                                                   *");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                           *");
            Console.WriteLine($"* Строка = {value}");
            Console.WriteLine($"* Символ замены = {item}");
            Console.WriteLine("**************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                 *");

            string result = ds.ReplaceNumOnChar(value, item);
            Console.WriteLine($"* {result}");

            Console.WriteLine("**************************************************************");
            Console.ReadKey();
        }
    }
}