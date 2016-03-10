/*Бандиты Гарри и Ларри отдыхали на природе. Решив пострелять, они выставили на бревно несколько банок из-под пива (не больше 10). 
Гарри начал простреливать банки по порядку, начиная с самой левой, Ларри — с самой правой. В какой-то момент получилось так, 
что они одновременно прострелили одну и ту же последнюю банку.
Гарри возмутился и сказал, что Ларри должен ему кучу денег за то, что тот лишил его удовольствия прострелить несколько банок.
В ответ Ларри сказал, что Гарри должен ему еще больше денег по тем же причинам. Они стали спорить кто кому сколько должен, 
но никто из них не помнил сколько банок было в начале, а искать простреленные банки по всей округе было неохота. 
Каждый из них помнил только, сколько банок прострелил он сам.
Определите по этим данным, сколько банок не прострелил Гарри и сколько банок не прострелил Ларри.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _1409_Cans
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] param = str.Split(' ');

            int[] x = new int[2];
            int i = 0;
            foreach (string s in param)
            {
                string tmp = string.Empty;
                Regex reg = new Regex(@"([0-9]+)");
                MatchCollection mc = reg.Matches(s);
                foreach (Match match in mc)
                   // tmp += match.Value;
                x[i] = int.Parse(tmp);
                i++;
            }
            for (int j = 1; j > -1; j--)
            {
                if (x[j] == 0)
                {
                    Console.Write(x[j]);
                    Console.Write(" ");
                }
                else {
                    Console.Write(x[j] - 1);
                    Console.Write(" ");
                }
            }
            Console.ReadLine();
        }
    }
}
