using System;

namespace Ex12._3._13
{
    /// <summary>
    /// Перебор зубчатого массива
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];

            arr[0] = new int[2] {1,2};
            arr[1] = new int[3] { 1, 2, 3 };
            arr[2] = new int[5] { 1, 2, 3, 4, 5 };

            foreach (var row in arr)
            {
                foreach (var item in row)
                {
                    Console.Write(item +" ");
                }
                Console.WriteLine();
            }

            

            Console.ReadKey();
        }
    }
}
