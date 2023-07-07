using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class TransposeMatrix
    {
        public void matrix(int row,int col)
        {
            
            int[,] arr1 = new int[30, 30];
            Console.WriteLine("Enter a array elements:");
            for (int i=0; i<row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    arr1[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }

           

            Console.WriteLine("transpose Matrix is:");

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write(arr1[j,i]+" "); 
                }
                Console.WriteLine(" ");
            }




        }
    }
}
