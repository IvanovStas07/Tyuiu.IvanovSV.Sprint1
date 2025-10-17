using Tyuiu.IvanovSV.Sprint1.task1.V14.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 3.0;
            double b = 2.0;
            double c = 1.0;
            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(7, res);
        }
    }
}