
using System;
using Tyuiu.UsoltsevME.Sprint4.Task0.V22.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task0.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите элемент массива [" + i + "]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = ds.GetSumOddArrEl(array);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.Write("Введённый массив: ");

            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Сумма нечётных элементов = " + result);

            Console.WriteLine("****************************************************");

            Console.ReadKey();
        }
    }
}
