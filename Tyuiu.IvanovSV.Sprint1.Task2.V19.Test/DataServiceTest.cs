using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSV.Sprint1.Task2.V19.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int inch = 1;
            var res = ds.ConvertInchToKm(inch);
            Assert.AreEqual(0.025, res);
        }
    }
}
