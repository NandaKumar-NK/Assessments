using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class PrimenumberSum
    {
        public int primenumber(int count)
        {
            int[] arr = new int[10];
            int[] parr = new int[10];
            int SumofPrime =0;

            Console.WriteLine("Enter a Elements: ");
            for (int i = 0; i < count; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
             
            for (int i = 0; i < count; i++)
            {
                int flag = 1;

                for (int j = 2; j <= arr[i] / 2; j++)
                {

                    if (arr[i] % j == 0)
                    {
                        
                        flag = 0;
                        break;
                        
                    }
                    

                }
                if (flag!=0)
                {
                    
                    SumofPrime += arr[i];
                   
                }
            }
            Console.WriteLine("Sum of prime numbers is "+SumofPrime);




            return SumofPrime;

            }

        }
    }

