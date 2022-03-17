using System;
using System.Collections.Generic;

//Создать случайный массив из 20 элементов, затем вывести из него максимальное и минимальное числа.

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            Random rand = new Random();
            int[] q = new int[20];
            for (int x = 0; x < q.Length; x++)
            {
                q[x] = rand.Next(20);
                Console.Write(q[x] + "\t");

            }
            max = q[0];
            min = q[0];
            for (int i = 1; i < 20; i++)
            {
                if (q[i] < min)
                    min = q[i];
                if (q[i] > max)
                    max = q[i];
            }
            Console.WriteLine(" ");
            Console.WriteLine("-------------------");
            Console.WriteLine("max = " + max);
            Console.WriteLine("min = " + min);
            Console.ReadLine();
        }
    }
}
