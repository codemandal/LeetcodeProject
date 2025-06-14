using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class _114FlattenBinaryTreetoLinkedList
    {
        public static void Flatten(TreeNode objRoot)
        {


            if (objRoot == null)
                return;

            TreeNode cur = objRoot;

            while (cur != null)
            {
                if (cur.left != null)
                {
                    TreeNode pred = cur.left;
                    while (pred.right != null & pred.right != cur)
                    {
                        pred = pred.right;
                    }
                    pred.right = cur.right;
                    cur.right = cur.left;
                    cur.left = null;
                }
                Console.WriteLine(cur.val + " ");
                cur = cur.right;
               
            }


            //Tushar Roy version: Morris Traversal Algorithm for inorder travers
            ////while (cur != null)
            ////{
            ////    if (cur.left == null)
            ////    {
            ////        Console.WriteLine(cur.val + " ");
            ////        cur = cur.right;
               

            ////    }
            ////    else
            ////    {

            ////        TreeNode prev = cur.left;
            ////        while (prev.right != cur && prev.right != null)
            ////        {
            ////            prev = prev.right;
            ////        }
            ////        if (prev.right == null)
            ////        {
            ////            prev.right = cur;
            ////            cur = cur.left;

                    
            ////        }
            ////        else
            ////        {
            ////            prev.right = null;
            ////            Console.WriteLine(cur.val + " ");
            ////            cur = cur.right;
            ////        }
            ////    }

            ////}



        }

        public static void PreOrder(TreeNode root)
        {
            if (root != null)
            {

                Console.WriteLine(root.val + " ");
                PreOrder(root.left);
                PreOrder(root.right);
            }
            else
                Console.WriteLine( "Null");
        }
     
    }
}
