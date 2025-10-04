using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSV.Sprint1.Task5.V1.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x1 = 1;
            double x2 = 2;
            double y1 = 2;
            double y2 = 3;
            DataService ds = new DataService();
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);

            int result = Convert.ToInt32(res);

            Assert.AreEqual(1,result);
        }
    }
}
