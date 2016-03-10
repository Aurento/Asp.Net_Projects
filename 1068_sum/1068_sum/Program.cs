/*Всё, что от вас требуется — найти сумму всех целых чисел, лежащих между 1 и N включительно.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1068_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string str = Console.ReadLine();
            int x = Int32.Parse(str);
            if (x < 1)
            {
                sum = ((2 * x + (1 - x)) * (2 - x)) / 2;
            }
            else
            {
                sum = ((2 + (x - 1)) * x) / 2;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
