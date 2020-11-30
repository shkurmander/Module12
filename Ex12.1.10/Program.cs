using System;

namespace Ex12._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 6;
            var b = 7;

            //var a = 6;  
            //var b = 6;    1й вариант

            //var a = 7;  
            //var b = 7;    2й вариант


            if (a == b)
            //if (a != b)   3й вариант
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }
            
        }
    }
}
