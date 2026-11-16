
using System;
using Tyuiu.UsoltsevME.Sprint4.Task3.V14.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] array = new int[5, 5];

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Введите элемент [" + i + ", " + j + "]: ");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int result = ds.Calculate(array);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ                                  *");
            Console.WriteLine("****************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Максимальный элемент четвертой строки = " + result);

            Console.ReadKey();
        }
    }
}
