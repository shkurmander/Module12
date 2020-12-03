using System;

namespace Ex12._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = {{ 1,2,3},{ 3,4,5},{ 6,7,8},{ 9,10,11} };

            for (int i = 0; i < array.GetUpperBound(1)+1; ++i)

            {
                for (int j = 0; j < array.GetUpperBound(1)+1; ++j)
                {
                    Console.Write(String.Format("{0,4}", array[i, j]));
                }
                Console.WriteLine();
            }
        }
    }
}
