using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BakhtiyarovDR.Sprint5.Task2.V9.Lib;
using System.IO;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task2.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData()
        {
            string path = @"C:\Users\Dinar\source\repos\Tyuiu.BakhtiyarovDR.Sprint5\Tyuiu.BakhtiyarovDR.Sprint5.Task2.V9\bin\Debug\OutPutFileTask2.csv";


            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
