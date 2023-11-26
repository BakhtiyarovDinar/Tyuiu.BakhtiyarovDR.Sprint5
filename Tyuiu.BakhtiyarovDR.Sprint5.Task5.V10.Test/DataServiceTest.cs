using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.BakhtiyarovDR.Sprint5.Task5.V10.Lib;

namespace Tyuiu.BakhtiyarovDR.Sprint5.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V10.txt";
            FileInfo fi = new FileInfo(path);
            bool fileex = fi.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
