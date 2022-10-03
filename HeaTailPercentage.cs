using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class HeadTailPercentage1
    {
        public static void HeadTailPercentage()
        {
            int n, h_cnt = 0, t_cnt = 0;
            double heads, tails;
            // INPUT DATA
            Console.WriteLine("enter no. of times you want to flip the coin: ");
            n = Convert.ToInt32(Console.ReadLine());

            // COMPUTATION
            for (int j = 0; j < n; j++)
            {
                Random random = new Random();
                double rnumber = random.Next(2);
                if (rnumber < 0.5)
                    t_cnt++;
                else
                    h_cnt++;
            }
            heads = h_cnt / (double)n * 100;
            tails = t_cnt / (double)n * 100;
            Console.WriteLine("Percentage of heads: " + heads + "%");
            Console.WriteLine("Percentage of tails: " + tails + "%");
            Console.ReadKey();

        }
    }
