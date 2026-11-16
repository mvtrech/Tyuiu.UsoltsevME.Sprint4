
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.UsoltsevME.Sprint4.Task7.V9.Lib
{
    public class DataService : ISprint4Task7V9
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];

            int count = 0;
            int k = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = Convert.ToInt32(value[k].ToString());

                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }

                    k++;
                }
            }

            return count;
        }
    }
}
