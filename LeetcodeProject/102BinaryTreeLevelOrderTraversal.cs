using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class _102BinaryTreeLevelOrderTraversal
    {
        public TreeNode root { get; set; }

        public TreeNode ReturnRoot()
        {
            return root;
        }
        public void Insert(int val)
        {
            TreeNode newNode = new(val);
            // newNode.val = val;

            if (root == null)
                root = newNode;
            else
            {
                TreeNode current = root;
                TreeNode parent;
                while (true)
                {
                    parent = current;
                    if (val < current.val)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            break;
                        }
                    }
                    else
                    {

                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            break;
                        }
                    }

                }

            }


        }
        public List<List<int>> LevelOrder(TreeNode root)
        {
           
            Queue<TreeNode> que = new Queue<TreeNode>();
            List<List<int>> lst = new List<List<int>>();
            if (root == null)
                return lst;
         
            int height = 0;
            que.Enqueue(root);
            while (que.Count > 0)
            {
                lst.Add(new List<int>());
                int length = que.Count();
                for (int i = 0; i < length; ++i)
                {
                    TreeNode node = que.Dequeue();

                    // fulfill the current level
                    lst[height].Add(node.val);

                    // add child nodes of the current level
                    // in the queue for the next level
                    if (node.left != null) que.Enqueue(node.left);
                    if (node.right != null) que.Enqueue(node.right);
                }
                height++;
            }

            return lst;


        }
    }
}
