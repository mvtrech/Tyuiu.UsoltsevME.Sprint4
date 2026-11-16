
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint4.Task0.V22.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task0.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetSumOddArrElTest()
        {
            DataService ds = new DataService();

            int[] array = { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };

            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(46, result);
        }

        [TestMethod]
        public void GetSumOddArrElAllEvenTest()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6, 8 };

            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetSumOddArrElNegativeTest()
        {
            DataService ds = new DataService();

            int[] array = { -3, -5, 2, 4, 7 };

            int result = ds.GetSumOddArrEl(array);

            Assert.AreEqual(-1, result);
        }
    }
}
