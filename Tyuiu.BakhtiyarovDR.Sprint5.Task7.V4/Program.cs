using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BakhtiyarovDR.Sprint5.Task7.V4.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task7.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService DataService = new DataService();
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                              *");
            Console.WriteLine("****************************************************************");
            string path = $@"C:\DataSprint5\InPutDataFileTask7V4.txt";
            string res = File.ReadAllText(path);
            Console.WriteLine(res); Console.WriteLine("Файл находится тут: " + path);
            Console.WriteLine("****************************************************************");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                     ");
            Console.WriteLine("****************************************************************");
            string w = DataService.LoadDataAndSave(path);
            Console.WriteLine("Cоздан!");
            Console.ReadKey();
        }
    }
}
