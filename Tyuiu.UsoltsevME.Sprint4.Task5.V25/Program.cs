
using Tyuiu.UsoltsevME.Sprint4.Task5.V25.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task5.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5];

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ВВОД ЭЛЕМЕНТОВ МАССИВА                           *");
            Console.WriteLine("****************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Введите элемент [" + i + "," + j + "]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            int result = ds.Calculate(matrix);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Сумма положительных элементов = " + result);

            Console.ReadKey();
        }
    }
}
