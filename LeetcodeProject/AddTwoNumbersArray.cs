using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public static class AddTwoNumbersArray
    {
        public static int AddTwoNumbers(int[] a, int[] b)
        {
            int ans= 0;

            //first find out which array is bigger between two as 
            if (a.Length < b.Length)
                return AddTwoNumbers(b, a);

            int i = a.Length-1;
            int j = b.Length - 1;
            List<int> sum = new List<int>();
            int carry = 0 , s = 0;
            while (j >= 0)
            {
                s = a[i] + b[j] + carry;
                carry = s / 10;


                sum.Add(s % 10);
                


                i--;
                j--;
            }

            while (i >= 0)
            {
                s = a[i] + carry;

                carry = s / 10;

                sum.Add(s%10);
                
                i--; 
            
            }

            for(int k = sum.Count-1; k>=0; k--)
            {
                ans = 10 * ans + sum[k];
            }
            return ans;
        }
    }
}
