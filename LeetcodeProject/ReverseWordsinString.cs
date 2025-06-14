using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public static class ReverseWordsinString
    {
        public static string ReverseWords(string s)
        {
            int i = 0;
            
           string[] a = s.Split(' ');
            a = a.Where(x => x != "").ToArray();
            int j = a.Length - 1;
            while (i < j) {
               
                    string temp = a[j];
                    a[j] = a[i];
                    a[i] = temp;
                
                i++;
                j--;
            }
            return string.Join(" ", a);
        }

        public static void ReverseWords2(char[] s)
        {
            reverseString(s, 0, s.Length - 1);
            ReverseEachWord(s);

        }

        public static void reverseString(char[] s, int left, int right)
        {
            while (left < right)
            {
                char tmp = s[left];
                s[left] = s[right];
                s[right] = tmp;
                left++;
                right--;
            }
            
        }

        public static void ReverseEachWord(char[] s)
        {
            int n = s.Length ;
            int start = 0;
            int end = 0;

            while (start < n)
            {
                while (end < n && s[end] != ' ')
                {
                    ++end;
                }
                reverseString(s, start, end - 1);
                start = end + 1;
                ++end;
            }
        }

        
    }
}
