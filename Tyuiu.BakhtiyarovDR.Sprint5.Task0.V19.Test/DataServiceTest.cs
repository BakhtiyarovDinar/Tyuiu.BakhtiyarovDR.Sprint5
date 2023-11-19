using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.BakhtiyarovDR.Sprint5.Task0.V19.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Dinar\source\repos\Tyuiu.BakhtiyarovDR.Sprint5\Tyuiu.BakhtiyarovDR.Sprint5.Task0.V19\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
