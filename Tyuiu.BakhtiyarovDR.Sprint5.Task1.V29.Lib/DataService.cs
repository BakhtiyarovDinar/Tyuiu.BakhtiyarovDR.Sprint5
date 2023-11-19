using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task1.V29.Lib
{
    public class DataService : ISprint5Task1V29
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask1.txt";
            double form;
            string result = "";
            for (int i = startValue; i <= stopValue; i++)
            {
                form = Math.Round(Math.Sin(i) / (i + 1.2) + Math.Cos(i) * 7 * i - 2, 2);
                if (double.IsInfinity(form) || double.IsNaN(form))
                {
                    form = 0;
                }
                result += form.ToString() + "\t";
            }
            File.WriteAllText(path, result);
            return path;
        }
    }
}
