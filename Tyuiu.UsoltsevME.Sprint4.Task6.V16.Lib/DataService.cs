
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UsoltsevME.Sprint4.Task6.V16.Lib
{
    public class DataService : ISprint4Task6V16
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, word => word.Length == 7);

            return result;
        }
    }
}
