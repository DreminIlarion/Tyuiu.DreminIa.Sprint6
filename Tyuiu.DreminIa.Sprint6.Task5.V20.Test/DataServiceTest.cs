using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SheludkovAA.Sprint6.Task5.V20.Lib;
using System.IO;

namespace Tyuiu.SheludkovAA.Sprint6.Task5.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Hines\source\repos\Tyuiu.DreminIa.Sprint66\Solution6\Tyuiu.DreminIa.Sprint6.Task5.V20\bin\Debug\InPutFileTask5V20.txt";
            FileInfo fi = new FileInfo(path);
            double[] wait = new double[2];
            double[] res = ds.LoadFromDataFile(path);
            wait[0] = 0 ;
            wait[1] = 12;
            Assert.AreEqual(wait[1], res[1]);
        }
    }
}
