using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Tyuiu.BakhtiyarovDR.Sprint5.Task0.V19.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task0.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 3;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Бахтияров Д. Р. | АСОиУб-23-3";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                                   *");
            Console.WriteLine("* Задание #0                                                                   *");
            Console.WriteLine("* Вариант #19                                                                  *");
            Console.WriteLine("* Выполнил Бахтияров Динар Русланович | АСОиУб-23-3                            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3                              *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask0.txt                     *");
            Console.WriteLine("*                                                                              *");
            Console.WriteLine("********************************************************************************");



            Console.WriteLine("******************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
            Console.WriteLine("******************************************************************************");

            string res = ds.SaveToFileTextData(y);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан");
            Console.ReadKey();
        }
    }
}
