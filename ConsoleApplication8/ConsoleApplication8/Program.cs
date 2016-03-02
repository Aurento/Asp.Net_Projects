using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            int leng = int.Parse(Console.ReadLine());
            string[] Str = Console.ReadLine().Split(' ');
            int[] Mass = new int[Str.Length];
            for (int i = 0; i < leng; i++)
            {
                Mass[i] = int.Parse(Str[i]);
            }
            for (int i = 0; i < leng; i++)
            {
                int k = Mass[i];
                for(int j=0; k>=0 ; j++)
                {
                    k -= j;
                    if (k == 1)
                    {
                        Console.Write("{0} ",k);
                        break;
                    }
                }
                if (k < 0)
                {
                    Console.WriteLine("0 ");
                }

            }
           
        }
    }
}
