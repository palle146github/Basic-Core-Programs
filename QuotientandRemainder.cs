﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class QuotientandRemainder1
    {
    public static void QuotientandRemainder()
    {
        Console.WriteLine("Enter a Dividend");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter a Divisior");
        int divisor = Convert.ToInt32(Console.ReadLine());
        int quotient = dividend / divisor;
        int remainder = dividend % divisor;
        Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
        Console.WriteLine("Quotient = " + quotient);
        Console.WriteLine("Remainder = " + remainder);
        Console.ReadLine();
    }
    }

