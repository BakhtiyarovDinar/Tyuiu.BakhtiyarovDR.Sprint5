using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.BakhtiyarovDR.Sprint5.Task4.V5.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistFile()
        {
            string path = @"C:\Users\Dinar\source\repos\Tyuiu.BakhtiyarovDR.Sprint5\Tyuiu.BakhtiyarovDR.Sprint5.Task4.V5\bin\Debug\InPutDataFileTask4V5.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string strX = @"C:\Users\Dinar\source\repos\Tyuiu.BakhtiyarovDR.Sprint5\Tyuiu.BakhtiyarovDR.Sprint5.Task4.V5\bin\Debug\InPutDataFileTask4V5.txt";
            double res = ds.LoadFromDataFile(strX);
            double wait = -127.963;

            Assert.AreEqual(wait, res);
        }
    }
}
