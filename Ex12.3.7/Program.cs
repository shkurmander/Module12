using System;

namespace Ex12._3._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine();

            for (int i = name.Length-1; i >= 0; --i)
            {
                Console.Write(name[i]);
            }
        }
    }
}
