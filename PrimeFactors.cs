using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PrimeFactors1
{
    public static void PrimeFactors()
    {
        int n;
        // INPUT DATA
        Console.WriteLine("Enter a Number : ");
        n = Convert.ToInt32(Console.ReadLine());

        int i = 2;
        Console.WriteLine("Prime Factors\n");
        while (n > 1)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i + " ");
                n = n / i;
            }
            else
            {
                i++;
            }
        }
        Console.WriteLine(" ");
        Console.ReadKey();
    }
}
