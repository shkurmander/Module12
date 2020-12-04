using System;

namespace Ex12._3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, -2, 9, 0, -11, 2, 14, 19, -9 };
            int amount = 0;
            Console.WriteLine("Массив:");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();

            foreach (var item in array)
            {
                if (item > 0) ++amount;
            }

            Console.WriteLine($"Количество положительных чисел в массиве: {amount}");
        }
    }
}
