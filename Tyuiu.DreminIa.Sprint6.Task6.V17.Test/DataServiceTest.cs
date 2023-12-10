using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.MartysevichAD.Sprint6.Task6.V17.Lib;

namespace Tyuiu.MartysevichAD.Sprint6.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Hines\source\repos\Tyuiu.DreminIa.Sprint66\Solution6\Tyuiu.DreminIa.Sprint6.Task6.V17\bin\Debug\InPutFileTask6V17.txt";
            DataService ds = new DataService();
            string wait = " wFrlYaZtHI XuLENkL BV ltxrhBXm HbJcPW";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}
