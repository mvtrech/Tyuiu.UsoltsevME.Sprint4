
using System;
using Tyuiu.UsoltsevME.Sprint4.Task4.V27.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix = new int[5, 5];

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("Введите элемент [" + i + ", " + j + "] от 1 до 9: ");

                    int value = Convert.ToInt32(Console.ReadLine());

                    while (value < 1 || value > 9)
                    {
                        Console.Write("Ошибка! Введите число от 1 до 9: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }

                    matrix[i, j] = value;
                }
            }

            int result = ds.Calculate(matrix);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЙ МАССИВ                                  *");
            Console.WriteLine("****************************************************");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.WriteLine("Сумма нечётных элементов = " + result);

            Console.ReadKey();
        }
    }
}
