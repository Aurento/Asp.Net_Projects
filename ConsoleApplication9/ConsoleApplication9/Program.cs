using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int leng = int.Parse(Console.ReadLine());
            int[] Ans = new int[leng];
            for (int i = 0; i < leng; i++)
            {
                int x = int.Parse(Console.ReadLine());
                int d = 8 * x - 7;
                
                double x_2 = Math.Sqrt(d) % 1;
                
                if (x_2 == 0)
                {
                    
                    Ans[i] = 1;
                }
                else
                {
                    Ans[i] = 0;
                }
            }
            
            for (int j = 0; j < leng; j++)
            {
                Console.Write("{0} ", Ans[j]);
            }
            Console.ReadLine();
        }
    }
}

