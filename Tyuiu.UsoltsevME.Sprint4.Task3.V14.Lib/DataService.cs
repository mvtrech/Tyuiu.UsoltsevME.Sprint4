
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UsoltsevME.Sprint4.Task3.V14.Lib
{
    public class DataService : ISprint4Task3V14
    {
        public int Calculate(int[,] array)
        {
            int max = array[3, 0];

            for (int i = 1; i < array.GetLength(1); i++)
            {
                if (array[3, i] > max)
                {
                    max = array[3, i];
                }
            }

            return max;
        }
    }
}
