using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public static class Palindorme
    {
       
        public static bool IsPalindrome(string s)
        {
            if (s.Length == 1)
            {
                return true;
            }

            var left = 0;
            var right = s.Length - 1;
            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                }
                else if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                }

                else
                {
                    if (char.ToLower(s[left]) != char.ToLower(s[right]))
                    {
                        return false;
                    }
                }
                left++;
                right--;
            }

            return true;
        }
    }
}
