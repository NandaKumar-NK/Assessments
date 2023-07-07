using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class StringCount
    {
        public StringCount(string psw) 
        {
            int alphaCount = 0;
            int numCount = 0;
            int splCount = 0;

            for(int i=0;i<psw.Length;i++)
            {
                if ((psw[i] >= 'a' && psw[i] <= 'z') || (psw[i] >= 'A' && psw[i] <= 'Z'))
                {
                    alphaCount++;
                }
                else if (psw[i] >= '0' && psw[i] <= '9')
                {
                    numCount++;
                }
                else
                {
                    splCount++;
                }
            }
            Console.WriteLine("Alphabets count in a string is: " + alphaCount);
            Console.WriteLine("Numbers count in a string is: " + numCount);
            Console.WriteLine("Speacial count in a string is: " + splCount);
        }
    }
}
