using System;

namespace Ex12._3._12
{
    /// <summary>
    /// Нахождение суммы элементов массива
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 9, 6, 11, 2, 14, 19, 9 };
            int sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            Console.WriteLine($"Сумма элементов массива: {sum}");

            Console.ReadKey();
        }
    }
}
