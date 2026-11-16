
using System;
using Tyuiu.UsoltsevME.Sprint4.Task2.V26.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task2.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            int[] array = new int[14];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введите элемент [" + i + "] от 1 до 8: ");

                int value = Convert.ToInt32(Console.ReadLine());

                while (value < 1 || value > 8)
                {
                    Console.Write("Ошибка! Введите число от 1 до 8: ");
                    value = Convert.ToInt32(Console.ReadLine());
                }

                array[i] = value;
            }

            int result = ds.Calculate(array);

            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            Console.Write("Массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Произведение нечётных элементов = " + result);

            Console.WriteLine("****************************************************");

            Console.ReadKey();
        }
    }
}
