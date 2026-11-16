
using Tyuiu.UsoltsevME.Sprint4.Task6.V16.Lib;

namespace Tyuiu.UsoltsevME.Sprint4.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                  *");
            Console.WriteLine("****************************************************");

            Console.Write("Введите количество слов: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string[] array = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Введите слово " + (i + 1) + ": ");
                array[i] = Console.ReadLine();
            }

            string[] result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                         *");
            Console.WriteLine("****************************************************");

            if (result.Length > 0)
            {
                Console.WriteLine("Слова длиной 7 символов:");

                foreach (string word in result)
                {
                    Console.WriteLine(word);
                }
            }
            else
            {
                Console.WriteLine("Слов длиной 7 символов не найдено.");
            }

            Console.ReadKey();
        }
    }
}
