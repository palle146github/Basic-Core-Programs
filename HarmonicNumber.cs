using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class HarmonicNumber1
    {
    public static void HarmonicNumber()
    {
        double result = 0;
        int n;
        // INPUT DATA
        Console.WriteLine("enter the harmonic you want to find: ");
        n = Convert.ToInt32(Console.ReadLine());
        if (n > 0)
        {

            for (int i = 1; i <= n; i++)
            {
                //sum += 1.0 / i;
                result = result + (1.0 / i);
            }
            Console.WriteLine("The Harmonic Value for the number is: " + result);
        }
        else
        {
            Console.WriteLine("The number should be greater than zero");
        }
        Console.ReadLine();
    }


    }

