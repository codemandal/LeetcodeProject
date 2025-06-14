using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public static class ValidParentheses
    {
        public static bool IsValidx(string s)
        {
            if (s.Length % 2 != 0)
                return false;

            int i = 0;
            List<char> a = new List<char>();
            while (i < s.Length)
            {
                if (s[i] == '{' || s[i] == '[' || s[i] == '(')
                    a.Add(s[i]);
                if (s[i] == '}' || s[i] == ']' || s[i] == ')')
                {
                    if (a.Count > 0)
                    {
                        if (s[i] == '}' && a.Last() == '{')
                            a.RemoveAt(a.Count-1);
                        else if (s[i] == ']' && a.Last() == '[')
                            a.RemoveAt(a.Count - 1);
                        else if (s[i] == ')' && a.Last() == '(')
                            a.RemoveAt(a.Count - 1);
                        else
                            return false;
                    }
                    else
                        return false;

                }
                i++;

            }
            if (a.Count == 0)
                return true;
            else
                return false;


        }

        
        private static readonly HashSet<char> CloseBrackets = new(new[] { ')', ']', '}' });

        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) return false;

            var stack = new Stack<char>(s.Length / 2 + 1);
            foreach (var ch in s)
            {
                if (CloseBrackets.Contains(ch))
                {
                    
                    if (stack.TryPop(out var previous))
                    {
                        switch (previous)
                        {
                            case '(' when ch == ')': continue;
                            case '[' when ch == ']': continue;
                            case '{' when ch == '}': continue;
                        }
                    }

                    return false;
                }

                stack.Push(ch);
            }

            return stack.Count == 0; // should be empty
        }
    }

}

