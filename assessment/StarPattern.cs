using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class StarPattern
    {
        public  StarPattern(int rows) 
        { 
            for(int i=0;i<rows; i++)
            {
                for(int j=0;j<=i;j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
           
        }

        

    }
}
