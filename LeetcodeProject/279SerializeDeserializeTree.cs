using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{

    public class TreeNode {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode()
        {
        }

        public TreeNode(int x)
        {
            val = x;
        }

      
    }
    public class _279SerializeDeserializeTree
    {
        public string serialize(TreeNode root) {
            return recSer(root, "");
        
        }
        public TreeNode deserialize(string data) {
            var Lst = data.Split(",").ToList();

            return recDesr(Lst);
        }


        public string recSer(TreeNode root, String str) {
            if (root == null)
                str += "null";
            else {
                str += root.val.ToString() + ",";
                str += recSer(root.left, str);
                str += recSer(root.right, str);
            }
            return str;
        }

        public TreeNode recDesr(List<String> l) {
            if (l[0] == "null")
            {
                l.RemoveAt(0);
                return null;
            }
            TreeNode root = new TreeNode(Convert.ToInt32(l[0]));
            l.RemoveAt(0);
            root.left = recDesr(l);
            root.right = recDesr(l);

            return root;

        }
    }
}
