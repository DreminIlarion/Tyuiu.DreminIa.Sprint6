using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint6.Task3.V16.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] {{ 14, 1, -3, 1, 10 },
                                        { 7, -3, 5, -4, 0 },
                                        { -10, -3, 5, -4, 0 },
                                        { -2, -2, -16, 2, -17 },
                                        { -16, 9, 5, -10, 16} };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = {{ 14, 1, -3, 1, 10 },
                           { 7, -3, 5, -4, 0 },
                           { 0, -3, 5, 0, 0 },
                           { -2, -2, -16, 2, -17 },
                            { -16, 9, 5, -10, 16} };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
