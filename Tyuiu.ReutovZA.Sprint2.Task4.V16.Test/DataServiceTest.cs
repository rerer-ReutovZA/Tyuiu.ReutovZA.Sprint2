using Tyuiu.ReutovZA.Sprint2.Task4.V16.Lib;

namespace Tyuiu.ReutovZA.Sprint2.Task4.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpressionWithTrueCondition()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double res = ds.Calculate(x, y);
            // Z = (1 + 1/3)^2 = 1.77777...
            double wait = 1.778;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidExpressionWithFalseCondition()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            double res = ds.Calculate(x, y);
            // Z = y - 1/x = 1 - 1/1 = 0
            double wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}