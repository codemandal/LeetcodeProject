using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class _380InsertDeleteGetRandomO1
    {
        Dictionary<int,int> dict;
        List<int>  List;
        Random rand = new Random();
        public _380InsertDeleteGetRandomO1() {
            dict = new Dictionary<int, int>();
            List = new List<int>();
        }

        public bool Insert(int val) {
            if (dict.ContainsKey(val))
                return false;

            dict.Add(val,List.Count);
            List.Add(val);
            return true;
        }

        public bool Remove(int val) {
            if (!dict.ContainsKey(val)) return false;


            int lastElement = List[List.Count - 1];
            dict.TryGetValue(val, out int getindex);
            List[getindex] = lastElement;
            dict[lastElement] = getindex;

            List.RemoveAt(List.Count - 1);
            dict.Remove(val);


            return true;
        
        }

        public int GetRandom() {
            return List[rand.Next(List.Count)];
        }

    }
}
