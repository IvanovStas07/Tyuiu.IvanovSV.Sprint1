using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSV.Sprint1.Task4.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y= 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.0625, res);
        }
    }
}
