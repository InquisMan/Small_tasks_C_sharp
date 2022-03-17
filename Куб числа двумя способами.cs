using System;

//Пользователь вводит число, нужно вывести куб этого числа при помощи функции (двумя способами).

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Способ №1
            int Cube(int x) => x * x * x;
            Console.Write("Введите число для его возведения в куб первым способом: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int result = Cube(c);
            Console.WriteLine(" ");
            Console.WriteLine($"x ^ 3 = {result}");
            Console.WriteLine(" ");
           
            //Способ №2
            double Stepen(double a)
            {
               a = Math.Pow(a, 3);
               return a;
            }    
            Console.Write("Введите число для его возведения в куб вторым способом: ");
            int b = Convert.ToInt32(Console.ReadLine());
            double result_2 = Stepen(b);
            Console.WriteLine(" ");
            Console.WriteLine($"x ^ 3 = {result_2}");
            Console.ReadLine();
        }
    }
}
