
using Tyuiu.UsoltsevME.Sprint4.Task7.V9.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task7.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите количество строк: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите строку из цифр: ");
            string value = Console.ReadLine();

            if (n <= 0 || m <= 0 || value.Length != n * m)
            {
                Console.WriteLine("Ошибка! Длина строки должна равняться произведению строк и столбцов.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Матрица:");

            int k = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(value[k] + "\t");
                    k++;
                }

                Console.WriteLine();
            }

            int result = ds.Calculate(n, m, value);

            Console.WriteLine();
            Console.WriteLine("Количество четных чисел: " + result);

            Console.ReadKey();
        }
    }
}
