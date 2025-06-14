using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class _217ContainsDuplicate
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            
            foreach (var v in nums.GroupBy(n => n))
            {
                if (v.Count() > 1)
                {
                    return true;
                }
                
                   
            }
            return false;
           // return (nums.GroupBy(n => n).Count() > 1) ? true : false;
        }
    }
}
