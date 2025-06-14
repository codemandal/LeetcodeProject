using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class SortingAlgorithms
    {
        public static int[] CountingSort(int[] a, int n)
        {
            int k = a.Max();
            int[] arrcoount = new int[k+1];
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                ++arrcoount[a[i]];
            }

            for (int i = 1; i <= k; i++) {
                arrcoount[i] = arrcoount[i] + arrcoount[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                b[--arrcoount[a[i]]] = a[i];
            }

            for (int i = 0; i < n; i++)
            {
                a[i] = b[i];
            }

            return a;
        
        }
        // Bubble Sort - two adjecent elements of array are compared. if elements are in correct positiion then move forward with next else swap the elements
        // optimized bubble sort where it is checking if there are no pass is done.
        public static int[] BubbleSort(int[] a)
        {
            int n = a.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool flag = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                        flag = true;
                    }
                    if (!flag)
                        break;
                }
            }

            return a;
        }
    }

   
}
