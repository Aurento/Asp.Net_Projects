/*Рассмотрим последовательность чисел ai, i = 0, 1, 2, …, удовлетворяющих следующим условиям:
a0 = 0
a1 = 1
a2i = ai
a2i + 1 = ai + ai + 1
для каждого i = 1, 2, 3, … .
Напишите программу, которая для заданного значения n находит максимальное среди чисел a0, a1, …, an.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxN
{
    class Program
    {
        static void Main(string[] args)
        {
            int max;
            int[] mas;
            int n = int.Parse(Console.ReadLine());
            while (n != 0)
            {
                max = 0;
                mas = new int[2 * n + 2];
                mas[0] = 0;
                mas[1] = 1;
                for (int i = 1; i <= n; i++)
                {
                    mas[2 * i] = mas[i];
                    mas[2 * i + 1] = mas[i] + mas[i + 1];
                    if (mas[i] > max)
                        max = mas[i];
                }
                Console.WriteLine(max);
                n = int.Parse(Console.ReadLine());
            }
        }
    }
}