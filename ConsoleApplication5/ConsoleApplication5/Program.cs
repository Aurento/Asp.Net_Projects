using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte leng = byte.Parse(Console.ReadLine());
            string[] Str = Console.ReadLine().Split(' ');
            int[] Mass = new int[Str.Length];
            int Sum = 0; 
            for (int i = 0; i < leng; i++)
            {
                Mass[i] = int.Parse(Str[i]);
                Sum += Mass[i];
            }
            int Min_dif = Sum;
            int Variants = (int)(Math.Pow(2, leng - 1) - 1);
            for (int i = 0; i < Variants; ++i)
            {
                int Num_Mass = i + 1, f = 0;
                byte[] A = new byte[leng];
                for (f = 0; Num_Mass != 1; f++)
                {
                    A[f] = (byte)(Num_Mass % 2);
                    Num_Mass /= 2;
                }
                A[f] = 1;
                int Heap1 = 0; 
                for (int t = 0; t < leng; t++)
                    if (A[t] == 1)
                        Heap1 += Mass[t];
                int Heap2 = Sum - Heap1;
                if (Min_dif > Math.Abs(Heap1 - Heap2))
                    Min_dif = Math.Abs(Heap1 - Heap2);
            }
            Console.WriteLine(Min_dif);
            Console.ReadLine();
        }
    }
}
