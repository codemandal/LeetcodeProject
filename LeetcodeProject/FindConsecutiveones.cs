using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public static class FindConsecutiveones
    {
        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            int mx = 0;
            int c = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                    c++;
                else
                {
                    mx = Math.Max(mx, c);
                    c = 0;
                
                }
            }
            nums = nums.OrderBy( x=> x).ToArray();
            return Math.Max(mx, c);


        }
    }
}
