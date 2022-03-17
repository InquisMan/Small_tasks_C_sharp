using System;

//Пользователь вводит два числа. Нужно определить, больше ли разница между ними, чем 10, или меньше.

namespace Задание_1
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
            Console.WriteLine(" ");
            int c = a - b;
            Console.WriteLine($"a - b = {c}");
            Console.WriteLine(" ");
            if (c > 10)
            {
                Console.WriteLine("Разница > 10");
            }
            
            else if (c < 10)
            {
                Console.WriteLine("Разница < 10");
            }

            else if (c == 10)
            {
                Console.WriteLine("Разница = 10");
            }
            Console.ReadLine();
        }
    }
}
