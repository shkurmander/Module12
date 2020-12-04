using System;

namespace Ex12._3._15
{
    class Program
    {
        /// <summary>
        /// Подсчет количества положительных чисел в двумерном массиве
        /// </summary>

        static void Main(string[] args)
        {
            int[,] array = { { 3, -2, 9, 0, -11 }, { 2, 14, 19, -9, -33 } };
            
            //Вывод массива
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.GetUpperBound(0)+1 ; ++i)

            {
                for (int j = 0; j < array.GetUpperBound(1)+1; ++j)
                {
                    Console.Write(String.Format("{0,4}", array[i, j]));
                }
                Console.WriteLine();
            }

            
            //Подсчет количества положительных чисел
            int amount = 0;
            foreach (var item in array)
            {
                if (item > 0) ++amount;
            }

            Console.WriteLine($"Количество положительных чисел в массиве: {amount}");

            Console.ReadKey();
        }
    }
}
