using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class _242ValidAnagrm
    {
        public static bool IsAnagram(string s, string t)
        {
           
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> dict1 = FillDictionary(s);


            for (int i = 0; i < t.Length; i++)
            {
                if (!dict1.ContainsKey(t[i]))
                    return false;

                if (dict1[t[i]] > 1)
                    dict1[t[i]]--;
                else
                    dict1.Remove(t[i]);

            }

            
            return dict1.Count == 0;

        }

        public static Dictionary<char, int> FillDictionary(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (!dict.ContainsKey(c))
                    dict.Add(c, 1);
                else
                    dict[c]++;
            }
            return dict;
        }

    }
}
