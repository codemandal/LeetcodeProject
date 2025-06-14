using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class braille_translation
    {
        public string solution(string plaintext)
        {
            string ans = string.Empty;
            var dictConvert = new Dictionary<string, string>
                {
                    {"a", "100000"},
                    {"b", "110000"},
                    {"c", "100100"},
                    {"d", "100110"},
                    {"e", "100010"},
                    {"f", "110100"},
                    {"g", "110110"},
                    {"h", "110010"},
                    {"i", "010100"},
                    {"j", "010110"},
                    {"k", "101000"},
                    {"l", "111000"},
                    {"m", "101100"},
                    {"n", "101110"},
                    {"o", "101010"},
                    {"p", "111100"},
                    {"q", "111110"},
                    {"r", "111010"},
                    {"s", "011100"},
                    {"t", "011110"},
                    {"u", "101001"},
                    {"v", "111001"},
                    {"w", "010111"},
                    {"x", "101101"},
                    {"y", "101111"},
                    {"z", "101011"},
                    {"#", "001111"},
                    {"1", "100000"},
                    {"2", "110000"},
                    {"3", "100100"},
                    {"4", "100110"},
                    {"5", "100010"},
                    {"6", "110100"},
                    {"7", "110110"},
                    {"8", "110010"},
                    {"9", "010100"},
                    {"0", "010110"},
                    {" ", "000000"},

            };

            foreach (var c in plaintext.ToCharArray())
            {
                if (Char.IsUpper(c))
                {
                    ans = ans + "0000001" + dictConvert[c.ToString()];
                }
                else {
                    ans = ans + dictConvert[c.ToString()];
                }

            }

            return ans;

        }
    }

    public static class bunny_worker_locations
    {
        public static string solution(int x, int y)
        {
            int hVal = 1;
            int wVal = 2;
            long ans = 0;
            for (int i = 1; i < y; i++)
            {
                hVal = hVal + i;
                wVal++;
            }
            ans = hVal;
            for (int i = 0; i < x-1; i++)
            {
                ans = ans + wVal + i;
            }

            return ans.ToString();
        }

    }
}
