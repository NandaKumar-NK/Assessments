using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assessment
{
    internal class SingleArray
    {
       

            public void Array(int i, int n)
            {
                //Reverse an array
                int[] arr1 = new int[10];
                Console.Write("Input number of elements in the array :\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("\n\nThe values store into the array in reverse are :\n");
                for (i = n - 1; i >= 0; i--)
                {
                    Console.Write("{0} ", arr1[i]);
                    Console.Write("\n");
                }
                //Dupicate Array
                int[] arr2 = new int[10];
                for (i = 0; i < n; i++)
                {
                    arr2[i] = arr1[i];
                }
                Console.WriteLine("The copied values of arr1 into arr2");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("{0}  ", arr2[i]);
                }
                //sum of elements in an array
                int sum = 0;
                for (i = 0; i < n; i++)
                {
                    sum += arr1[i];
                }

                Console.WriteLine("Sum of all elements stored in the array is : {0}", sum);
                //count total no of duplicate elements in an array
                int[] arr3 = new int[10];
                int mm = 1, ctr = 0, j;
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        if (arr1[i] == arr2[j])
                        {
                            arr3[j] = mm;
                            mm++;
                        }
                    }
                    mm = 1;
                }
                for (i = 0; i < n; i++)
                {
                    if (arr3[i] == 2) { ctr++; }
                }
                Console.Write("The number of duplicate elements is: {0} \n", ctr);
                //unique numbers in an array
                int k;
                Console.Write("\nThe unique elements found in the array are : ");
                for (i = 0; i < n; i++)
                {
                    ctr = 0;
                    for (j = 0; j < i - 1; j++)
                    {
                        if (arr2[i] == arr2[j])
                        {
                            ctr++;
                        }
                    }
                    for (k = i + 1; k < n; k++)
                    {
                        if (arr2[i] == arr2[k])
                        {
                            ctr++;
                        }
                        if (arr2[i] == arr2[i + 1])
                        {
                            i++;
                        }
                    }

                    if (ctr == 0)
                    {
                        Console.Write("{0} \n", arr2[i]);
                    }
                }
                //second largest number in an array
                int lrg1, lrg2;
                lrg1 = 0;
                j = 0;

                for (i = 0; i < n; i++)
                {
                    if (lrg1 < arr2[i])
                    {
                        lrg1 = arr2[i];
                        j = i;
                    }
                }
                lrg2 = 0;
                for (i = 0; i < n; i++)
                {
                    if (i == j)
                    {
                        i++;  /* ignoring the largest element */
                        i--;
                    }
                    else
                    {
                        if (lrg2 < arr2[i])
                        {
                            lrg2 = arr2[i];
                        }
                    }
                }

                Console.Write("The Second largest element in the array is :  {0} ", lrg2);
            }
        }
       
    }

