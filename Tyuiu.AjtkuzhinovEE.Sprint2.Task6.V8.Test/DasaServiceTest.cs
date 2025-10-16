using Tyuiu.AjtkuzhinovEE.Sprint2.Task6.V8.Lib;

namespace Tyuiu.AjtkuzhinovEE.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DasaServiceTest
    {
        [TestMethod]
        public void ValidFindFindDateOfPreviousDay()
        {
            DataService ds = new DataService();
            int n = 25;

            Assert.AreEqual("24.05", ds.FindDateOfPreviousDay(n, 1));

            


        }
    }
}
