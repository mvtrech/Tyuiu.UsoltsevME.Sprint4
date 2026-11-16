
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint4.Task1.V25.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            int[] array = { 6, 3, 6, 4, 7, 4, 6, 5, 2, 3, 6, 3, 6, 2 };

            int result = ds.Calculate(array);

            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void CalculateAllEvenTest()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6, 2 };

            int result = ds.Calculate(array);

            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void CalculateAllOddTest()
        {
            DataService ds = new DataService();

            int[] array = { 1, 3, 5, 7 };

            int result = ds.Calculate(array);

            Assert.AreEqual(0, result);
        }
    }
}
