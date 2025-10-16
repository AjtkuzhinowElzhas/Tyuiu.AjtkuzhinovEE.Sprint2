using Tyuiu.AjtkuzhinovEE.Sprint2.Task4.V10.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint2.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 3;
            double res = ds.Calculate(x, y);
            double wait = 1;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 3;
            double res = ds.Calculate(x,y);
            double wait = 52;
            Assert.AreEqual(wait, res);
        }
    }
}
