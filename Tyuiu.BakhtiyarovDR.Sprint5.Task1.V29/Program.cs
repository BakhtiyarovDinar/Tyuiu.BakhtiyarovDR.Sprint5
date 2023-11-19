using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BakhtiyarovDR.Sprint5.Task1.V29.Lib;
using System.IO;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task1.V29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Бахтияров Д. Р. | АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("*Тема: Создания итогового решения по спринту                              *");
            Console.WriteLine("*Задание #1                                                               *");
            Console.WriteLine("*Вариант #29                                                              *");
            Console.WriteLine("*Выполнил: Бахтияров Динар Русланович | АСОиУБ-23-3                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение и сохраняет             *");
            Console.WriteLine("*  в текстовый файл OutPutFileTask1.txt                                   *");
            Console.WriteLine("*                                                                         *");

            // Место решения задания
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("диапазон [-5; 5]                                                          *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;
            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
