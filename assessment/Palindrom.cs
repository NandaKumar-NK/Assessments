using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class Palindrom
    {
        public void StringPalindrom(string name) {
            string rev;
            char[] ch = name.ToCharArray();
            Array.Reverse(ch);
            rev = new string(ch);
            bool b = name.Equals(rev, StringComparison.OrdinalIgnoreCase);
            if (b == true)
            {
                Console.WriteLine("" + name + " is a Palindrome!");
            }
            else
            {
                Console.WriteLine(" " + name + " is not a Palindrome!");
            }

        }
        public void NumberPalindrom(int num)
        {
            int  r, sum = 0, temp;
            temp = num;
            while (num > 0)
            {
                r = num % 10;
                sum = (sum * 10) + r;
                num = num / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }

    }
    }

