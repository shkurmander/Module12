using System;

namespace Ex12._3._16
{
    /// <summary>
    /// Сортировка двумерного массива построчно
    /// </summary>
    class Program
    {
        //Метод форматированного вывода двумерного массива
        public static void Print(ref int[,] array)
        {
            //Вывод массива
            for (int i = 0; i < array.GetUpperBound(0) + 1; ++i)

            {
                for (int j = 0; j < array.GetUpperBound(1) + 1; ++j)
                {
                    Console.Write(String.Format("{0,4}", array[i, j]));
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] arr = { { 1, 2, 3, -2 }, { 3, 4, 0, 5 }, { 17, 6, 7, 8 }, { -13, 9, 10, 11 } };

            Console.WriteLine("Исходный массив:");

            Print(ref arr);

            //Сортировка пузырьком каждой строки
            int buf;                                            //буфферная переменная
            for (int i = 0; i < arr.GetUpperBound(0) + 1; ++i)
            {
                for (int j = 0; j < arr.GetUpperBound(1); ++j)
                {
                    for(int k = j + 1; k < arr.GetUpperBound(1)+1; ++k)
                    if (arr[i,k] < arr[i,j])
                    {
                        buf = arr[i,j];
                        arr[i,j] = arr[i,k];
                        arr[i,k] = buf;
                    }
                }
            }

            Console.WriteLine("\nОтсортированный массив:");

            Print(ref arr);

            Console.ReadKey();
        }
    }
}
