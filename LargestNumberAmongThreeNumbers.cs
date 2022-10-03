using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

    public class LargestNumberAmongThreeNumbers1
    {
        public static void LargestNumberAmongThreeNumbers()
        {
            int num1, num2, num3;
        // set the value of the three numbers
        Console.WriteLine(" Enter Number one ");
            num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Number two ");
            num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(" Enter Number three ");
            num3 = Convert.ToInt32(Console.ReadLine());
        if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("Number one is the largest!\n");
                }
                else
                {
                    Console.Write("Number three is the largest!\n");
                }
            }
            else if (num2 > num3)
                Console.Write("Number two is the largest!\n");
            else
                Console.Write("Number three is the largest!\n");
        Console.ReadKey();
        }
    }