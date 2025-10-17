using Tyuiu.IvanovSV.Sprint1.Task6.V3.Lib;

namespace Tyuiu.IvanovSV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "привет! это строка - проверка. Да";
            DataService ds = new DataService();
            string res = ds.LastLetterWord(strTest);
            string wait = "тоааа";
            Assert.AreEqual(wait, res);
        }
    }
}
