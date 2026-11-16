
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint4.Task4.V27.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 4, 3, 9, 2, 2 },
                { 8, 4, 1, 4, 3 },
                { 3, 9, 2, 2, 5 },
                { 4, 6, 8, 5, 6 },
                { 1, 5, 2, 2, 5 }
            };

            int result = ds.Calculate(matrix);

            Assert.AreEqual(49, result);
        }

        [TestMethod]
        public void CalculateAllEvenTest()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 2, 4, 6, 8, 2 },
                { 4, 6, 8, 2, 4 },
                { 6, 8, 2, 4, 6 },
                { 8, 2, 4, 6, 8 },
                { 2, 4, 6, 8, 2 }
            };

            int result = ds.Calculate(matrix);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void CalculateAllOddTest()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 1, 3, 5, 7, 9 },
                { 1, 3, 5, 7, 9 },
                { 1, 3, 5, 7, 9 },
                { 1, 3, 5, 7, 9 },
                { 1, 3, 5, 7, 9 }
            };

            int result = ds.Calculate(matrix);

            Assert.AreEqual(125, result);
        }
    }
}
