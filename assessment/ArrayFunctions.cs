using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class ArrayFunctions
    {
        int[] arr=new int[10];
        public ArrayFunctions(int n)
        {
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        public void ArraySort()
        {
            int temp = 0;
            for(int i=0;i<arr.Length-1;i++)
            {
                for(int j = 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach(int num in arr) { 
                Console.WriteLine(num);
            }

        }
        public void ArrayReverse()
        {

        }
    }
}
