using System;

//Вывести промежуток чисел от 1 до 101, за исключением чётных и чисел, кратных 5.

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 102; i++)
            {
                if (i % 2 != 0 & i % 5 != 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
