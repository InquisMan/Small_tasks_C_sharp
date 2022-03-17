using System;

//Пользователь вводит два числа a и b. Нужно найти их НОД (наибольший общий делитель).

namespace Задание_3
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
            while (a != 0 & b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            int c = a + b;
            Console.WriteLine($"НОД: {c}");
            Console.ReadLine();
        }
    }
}