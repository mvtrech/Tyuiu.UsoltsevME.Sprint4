
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint4.Task3.V14.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 3, 2, 3, 3, 5 },
                { 2, 3, 3, 7, 3 },
                { 7, 5, 2, 7, 3 },
                { 4, 2, 7, 5, 2 },
                { 3, 5, 4, 2, 6 }
            };

            int result = ds.Calculate(array);

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void CalculateNegativeTest()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 1, 2, 3, 4, 5 },
                { 5, 4, 3, 2, 1 },
                { 0, 0, 0, 0, 0 },
                { -8, -3, -6, -2, -9 },
                { 1, 1, 1, 1, 1 }
            };

            int result = ds.Calculate(array);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void CalculateOneRowTest()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 1, 2, 3, 4, 5 },
                { 10, 20, 30, 40, 50 },
                { 1, 2, 3, 4, 5 }
            };

            int result = ds.Calculate(array);

            Assert.AreEqual(50, result);
        }
    }
}
