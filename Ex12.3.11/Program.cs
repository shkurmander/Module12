using System;

namespace Ex12._3._11
{   
/// <summary>
/// Сортировка массива, пузырек и встроенная интроспективная сортировка.
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 3, 5, 9, 6, 11, 2, 14, 19, 9 };

            //встроенная интроспективная сортировка.
            int[] sortedArray = new int[array.Length];          //инициализируем массив аналогичный исходному
            Array.Copy(array, sortedArray,array.Length);        //копируем исходный массив
            Array.Sort(sortedArray);                            //применяем встроенный метод сортировки 

            Console.WriteLine("Array.Sort()");
            foreach (var item in sortedArray)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            //Сортировка пузырьком
            int buf;                                            //буфферная переменная
            for (int i = 0; i < array.Length-1; ++i)
            {
                for (int j = i + 1; j < array.Length; ++j)
                {
                    if (array[j]<array[i])
                    {
                        buf = array[i];
                        array[i] = array[j];
                        array[j] = buf;
                    }
                }
            }
            Console.WriteLine("Пузырек:");

            foreach (var item in array)
            {
                Console.Write(item + " ");
            }

            Console.ReadKey();

        }
    }
}
