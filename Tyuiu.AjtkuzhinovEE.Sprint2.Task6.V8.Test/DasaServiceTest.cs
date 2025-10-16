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
            int n = 13;

            Assert.AreEqual("12.11", ds.FindDateOfPreviousDay(n, 1));

            


        }
    }
}
