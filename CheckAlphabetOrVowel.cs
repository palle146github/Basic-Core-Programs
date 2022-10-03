using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



public class CheckAlphabetIsVowelOrConsonant1
    {
    public static void CheckAlphabetIsVowelOrConsonant()
    {
        char ch;

        Console.WriteLine("Enter any character: ");
        ch = Convert.ToChar(Console.ReadLine());
        // Condition for vowel checking
        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
        {
            Console.WriteLine(ch + " is Vowel.");
        }
        else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
        {
            Console.WriteLine(ch + " is Consonant.");
        }

        Console.ReadKey();
    }
}
