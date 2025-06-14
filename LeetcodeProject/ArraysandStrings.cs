using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class ArraysandStrings
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictSum = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int val = (int)(target - nums[i]);
                if (dictSum.ContainsKey(val))
                {
                    int[] toreturn = { dictSum[val], i };
                    return toreturn;
                }
                else
                {
                    if (!dictSum.ContainsKey(nums[i]))
                        dictSum.Add(nums[i], i);
                }

            }
            return null;

        }

        public static bool IsPalindrome(string s)
        {
            s = System.Text.RegularExpressions.Regex.Replace(s, "[^a-zA-Z0-9]", string.Empty).ToLower();
            int j = s.Length - 1;
            for (int i = 0; i < j; i++)
            {
                if (s[i] != s[j])
                    return false;
                j--;
            }
            return true;

        }
        public int MyAtoi(string s)
        {
            long ans = 0;
            
            string strNumber = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '-' || s[i] == '+' || Char.IsNumber(s[i]))
                {


                    if (s[i] == '-' && !strNumber.Contains('-') && !strNumber.Contains('+') && strNumber.Length == 0)
                        strNumber = "-";
                    else if (s[i] == '+' && !strNumber.Contains('+') && !strNumber.Contains('-') && strNumber.Length == 0)
                        strNumber = "";
                    else if (Char.IsNumber(s[i]))
                        strNumber = strNumber + s[i];
                    else
                        break;
                    
                    
                }
            }
            if (strNumber.Length > 0)
            {
                foreach (char c in strNumber)
                {
                    if (c != '-' && c != '+')
                    {

                        ans = ans * 10 + GetValue(c);

                        if (ans * -1 < int.MinValue && strNumber[0] == '-')
                        {
                            return int.MinValue;
                        }
                        else if (ans > int.MaxValue - 1 && strNumber[0] != '-')
                        {
                            return int.MaxValue;
                        }
                    }
                }
                return (strNumber[0] == '-') ? (int)ans * -1 : (int)ans;
            }
            else
                return (int)ans;


            
        }

        public static int GetValue(char c)
        {
            switch (c)
            {
                case '0':
                    return 0;
                case '1':
                    return 1;
                case '2':
                    return 2;
                case '3':
                    return 3;
                case '4':
                    return 4;
                case '5':
                    return 5;
                case '6':
                    return 6;
                case '7':
                    return 7;
                case '8':
                    return 8;
                case '9':
                    return 9;
                default:
                    return -1;

            }
        }

        //public IList<IList<string>> GroupAnagrams(string[] strs)
        //{
        //    foreach(string s in strs)
        //    {

        //    }


        //}

    }
}
