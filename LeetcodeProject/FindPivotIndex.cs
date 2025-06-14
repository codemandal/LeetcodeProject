using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class FindPivotIndex
    {
        public static int PivotIndex(int[] nums)
        {
            int sum = 0, leftsum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                leftsum += nums[i];
                if (leftsum- nums[i] == sum - leftsum )
                    return i;
                
            }

            return -1;
        }
    }
}
