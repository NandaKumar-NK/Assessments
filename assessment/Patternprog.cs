using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class Patternprog
    {
        public Patternprog(int rows) {
            
                int count = 1;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(count + " ");
                        count++;
                    }
                    Console.WriteLine();
                }
            }
        public void pattern1(int limit)
        {
            int num = 1;
            for(int row = 1; row <= limit; row++)
            {
                for (int space = 1; space <= limit - row; space++)
                    Console.Write(" ");
                    for(int col = 1; col <= row; col++)
                {
                    Console.Write(num+" ");
                    num++;
                }
                    Console.WriteLine();
            }
        }
    }
    }
