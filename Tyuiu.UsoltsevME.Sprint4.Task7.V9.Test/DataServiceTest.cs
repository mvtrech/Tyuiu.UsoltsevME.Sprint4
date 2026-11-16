
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint4.Task7.V9.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            int n = 3;
            int m = 3;
            string value = "864299753";

            int wait = 4;

            int result = ds.Calculate(n, m, value);

            Assert.AreEqual(wait, result);
        }
    }
}
