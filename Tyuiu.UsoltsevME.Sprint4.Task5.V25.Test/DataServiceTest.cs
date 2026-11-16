
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint4.Task5.V25.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculatePositiveElements()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 1, -2, 3, -4, 2 },
                { -1, 2, -3, 4, -2 },
                { 3, 1, -4, 2, -1 },
                { -3, 4, 1, -2, 3 },
                { 2, -1, 4, -3, 1 }
            };

            int wait = 33;

            int result = ds.Calculate(matrix);

            Assert.AreEqual(wait, result);
        }
    }
}
