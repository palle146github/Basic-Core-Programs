using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PowersOfTwo1
{
    public static void PowersOfTwo()
        {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Power of 2^"+num+" is: "+(Math.Pow(2, num)));
        Console.WriteLine("Printing all till Power Value "+num);
        if (num > 31)
        {
            Console.WriteLine("value of number should be less than 31");
            return;
        }
        else
        {
            for (int j = 1; j <= num; j++)
            {
                Console.WriteLine("Power of 2^" + j + " is: " + (Math.Pow(2, j)));
            }
        }
        Console.ReadKey();
    }
}
