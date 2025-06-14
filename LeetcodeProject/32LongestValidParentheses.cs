using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class _32LongestValidParentheses
    {
        public static int longestValidParentheses(String s)
        {
            Stack<int> chStack = new Stack<int>();
            int ans = 0;
           
            chStack.Push(-1);
            for(int i=0; i< s.Length; i++)
            {
                if (s[i] == '(')
                {
                    chStack.Push(i);
                }
                else
                {
                    chStack.Pop();
                    if (chStack.Count == 0)
                        chStack.Push(i);
                    else
                        ans = Math.Max(ans, i - chStack.Peek());
                    
                }

            }
            

            return ans;



        }
    }
}
