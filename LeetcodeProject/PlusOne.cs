using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class PlusOne
    {
        public static int[] GetPlusOne(int[] digits)
        {
            var x = Math.Pow(10, digits.Length-1);
            long sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum = sum + (long) x * digits[i];
                x = x / 10;

            }
            sum = sum + 1;
            var arr = new List<int>();
            while (sum != 0)
            {
               
                arr.Insert(0, (int)(sum % 10));
                sum = sum / 10;
            }
            

            return arr.ToArray();
        }
    }
}
