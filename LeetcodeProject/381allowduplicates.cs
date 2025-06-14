using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class _381allowduplicates
    {
       // Dictionary<int, int> dict;
        List<int> lst;
        Random rand = new Random();
        Dictionary<int, HashSet<int>> dict;
        public _381allowduplicates()
        {
           
            lst = new List<int>();
            dict = new Dictionary<int, HashSet<int>>();
            
        }

        public bool Insert(int val)
        {
            if (!dict.ContainsKey(val))
                dict.Add(val, new HashSet<int>());

            dict[val].Add(lst.Count);
            lst.Add(val);
            return (dict[val].Count == 1) ? true : false;
        }

        public bool Remove(int val)
        {
            if (!dict.ContainsKey(val) || dict[val].Count == 0) return false;


          


            return true;

        }

        //public int GetRandom()
        //{
        //    return List[rand.Next(List.Count)];
        //}
    }
}
