using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSV.Sprint1.Task3.V12.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 3;
            double end = 6;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(end, res); 
        }
    }
}
