using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{

    public class _144BinaryTreePreOrderTraversal
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
        public IList<int> PreorderTraversal(TreeNode root)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            List<int> lst = new List<int>();
            if (root == null)
                return lst;
            stack.Push(root);
            while (stack.Count > 0)
            {
                TreeNode node = stack.Peek();
                lst.Add(node.val);
                stack.Pop();
                if (node.right != null)
                    stack.Push(node.right);
                if (node.left != null)
                    stack.Push(node.left);

            }
            return lst;
        }
    }
}
