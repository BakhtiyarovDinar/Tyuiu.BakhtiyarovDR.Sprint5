using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.BakhtiyarovDR.Sprint5.Task5.V10.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task5.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Бахтияров Д. Р. |  АСОиУБ-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*Спринт #5                                                                *");
            Console.WriteLine("*Тема: Чтение набора данных из текстового файла                           *");
            Console.WriteLine("*Задание #5                                                               *");
            Console.WriteLine("*Вариант #10                                                              *");
            Console.WriteLine("*Выполнил: Бахтияров Динар Русланович | АСОиУБ-23-3                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                 *");
            Console.WriteLine("*Дан файл С:|DataSprint5|InPutDataFileTask5V0.txt (файл взять из архива   *");
            Console.WriteLine("*согласно вашему варианту. Создать папку в ручную С:|DataSprint5| и       *");
            Console.WriteLine("*скопировать в неё файл) в котором есть набор значений. Найти сумму всех  *");
            Console.WriteLine("*четных целых чисел в файле.  Полученный результат вывести на консоль.    *");
            Console.WriteLine("*У вещественных значений округлить до трёх знаков после запятой.          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ                                                          *");
            Console.WriteLine("***************************************************************************");

            string path = $@"C:\DataSprint5\InPutDataFileTask5V10.txt";

            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            var res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
