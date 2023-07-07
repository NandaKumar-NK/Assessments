using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class NumPattern
    {
        public  NumPattern(int rows)
        {

            for (int i = 0; i < rows; i++)
            {
                int Count = 1;
                for (int j = rows-1; j >= i ; j--)
                {
                    Console.Write("  ");
                }
                for (int k=0; k <=i;k++)
                {
                    Console.Write(Count++ +"   ");
                }

             
                Console.WriteLine();

            }
        }
    }
}
