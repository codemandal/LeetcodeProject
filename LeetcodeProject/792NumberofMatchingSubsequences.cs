using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class _792NumberofMatchingSubsequences
    {
        public static int NumMatchingSubseq(string s, string[] words)
        {
            /*
                The idea is to find if each of the word in words is a subsequence of a string s.
                Now, there might be duplicate word in words, so, we cache that count using dictionary
            */
            int res = 0;
            var wordsToCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (wordsToCount.ContainsKey(word))
                {
                    wordsToCount[word]++;
                }
                else
                {
                    wordsToCount.Add(word, 1);
                }
            }

            foreach (string word in wordsToCount.Keys)
            {
                if (IsSubSequence(s, word))
                {
                    res += wordsToCount[word];
                }
            }

            return res;
        }

        private static bool IsSubSequence(string s, string word)
        {
            int m = s.Length;
            int n = word.Length;
            int i = 0;
            int j = 0;
            while (i < m && j < n)
            {
                if (word[j] == s[i])
                {
                    j++;
                }
                i++;
            }
            return j == n;
        }
   
    }
}
