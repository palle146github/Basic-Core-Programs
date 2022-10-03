using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class LeapYearOrNot1
    {
        public static void LeapYearOrNot()
    {
        Console.WriteLine("Enter Year==>");
        string userName = Console.ReadLine();
        int length = userName.Length;
        Console.WriteLine(length);
        int year = Int16.Parse(userName);
        if (length != 4)
        {
            Console.WriteLine("enter year as 4 digit number");
            return;
        }
        else
        {
            if (year % 400 == 0 && year % 100 == 0)
                Console.WriteLine("year " + year + " is a leap year");
			else if (year % 100 != 0 && year % 4 == 0)
                Console.WriteLine("year " + year + " is a leap year");
			else
                Console.WriteLine("year " + year + " is not a leap year");
            Console.ReadKey();
        }
    }

    }

