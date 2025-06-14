using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class DominantIndex
    {
        public static int GetDominantIndex(int[] nums)
        {
            int max = 0;
            int maxindex = 0;
            int seconMax = 0;
          
            if (nums.Length == 1)
                return 0;

            for(int i=0; i< nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    maxindex = i;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > seconMax && nums[i] < max)
                {
                    seconMax = nums[i];
                   
                }
            }
            if (seconMax == 0)
                return maxindex;
            else if (max / seconMax >= 2)
                return maxindex;
            else
                return -1;

        }
    }
}
