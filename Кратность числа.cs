using System;

//Пользователь вводит числа а и b. Нужно определить, кратно ли число a числу b.

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Введите b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a % b;
            if (c == 0)
            {
                Console.WriteLine(" ");
                Console.WriteLine("a кратно b");
                Console.ReadLine();
                Console.WriteLine(" ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("a не кратно b");
                Console.ReadLine();
                Console.WriteLine(" ");
            }
        }
    }
}