
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint4.Task2.V26.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6 };

            int result = ds.Calculate(array);

            Assert.AreEqual(1575, result);
        }

        [TestMethod]
        public void CalculateAllEvenTest()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6, 8 };

            int result = ds.Calculate(array);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void CalculateOneElementTest()
        {
            DataService ds = new DataService();

            int[] array = { 5 };

            int result = ds.Calculate(array);

            Assert.AreEqual(5, result);
        }
    }
}
