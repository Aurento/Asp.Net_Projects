using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            byte Count = byte.Parse(Console.ReadLine());
            string[] Str = Console.ReadLine().Split(' ');
            int[] Mass_gr = new int[Str.Length];
            for (int i = 0; i < Count; i++)
            {
                Mass_gr[i] = int.Parse(Str[i]);
            }
            double gap = Count;
            bool swapped = true;
            while (gap>1 || swapped)
            {
                    gap /= 1.24733095;
                if (gap < 1)
                {
                    gap = 1;
                }
                int i = 0;
                swapped = false;
                while (i+gap < Count)
                {
                    int igap = i + (int)gap;
                    if (Mass_gr[i] > Mass_gr[igap])
                    {
                        int t = Mass_gr[i];
                        Mass_gr[i] = Mass_gr[igap];
                        Mass_gr[igap] = t;
                        swapped = true;
                    }
                    i++;
                }
            }
            int Sum = 0;
            for (int j =0; j < (Count/2+1); j++)
            {
                Sum += (Mass_gr[j] / 2) + 1;
            }
            Console.WriteLine(Sum);
            Console.ReadLine();

        }
    }
}
