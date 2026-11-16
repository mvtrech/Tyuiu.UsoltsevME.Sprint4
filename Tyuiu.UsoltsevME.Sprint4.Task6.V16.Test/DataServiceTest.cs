
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.UsoltsevME.Sprint4.Task6.V16.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task6.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CalculateTest()
        {
            DataService ds = new DataService();

            string[] array =
            {
                "Автомобиль",
                "Велосипед",
                "Самолет",
                "Поезд",
                "Трамвай",
                "Троллейбус",
                "Метро"
            };

            string[] wait = { "Самолет", "Трамвай" };

            string[] result = ds.Calculate(array);

            CollectionAssert.AreEqual(wait, result);
        }
    }
}
