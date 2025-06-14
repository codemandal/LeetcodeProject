using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class MyNode
    {
        public int data;
        public MyNode left;
        public MyNode right;
        public void printNode() {
            Console.WriteLine(data + " ");
        }
    }
    public class MyTree
    {
        public MyNode root { get; set; }

        public MyTree()
        {
            root = null;
        }
        public MyNode ReturnRoot()
        {
            return root;
        }
        public void Insert(int val)
        {
            MyNode newNode = new MyNode();
            newNode.data = val;

            if (root == null)
                root = newNode;
            else {
                MyNode current = root;
                MyNode parent;
                while (true)
                {
                    parent = current;
                    if (val < current.data)
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

        public void PreOrder(MyNode objRoot)
        {
            if (objRoot != null)
            {
                Console.Write(objRoot.data + " ");
                PreOrder(objRoot.left);
                PreOrder(objRoot.right);
            }
        }

        public void InOrder(MyNode objRoot)
        {
            if (objRoot != null)
            {
                InOrder(objRoot.left);
                Console.Write(objRoot.data + " ");
                InOrder(objRoot.right);
            }
        }

        public void PostOrder(MyNode objRoot)
        {
            if (objRoot != null)
            {
                PostOrder(objRoot.left);
                PostOrder(objRoot.right);
                Console.Write(objRoot.data + " ");

            }
            
        }

        public void iterativePreOrderx(MyNode objRoot)
        {
            LinkedList<MyNode> stack = new LinkedList<MyNode>();
           
            if (objRoot == null)
                Console.Write(" ");

            stack.AddFirst(objRoot);
            while (stack.Count > 0)
            {
                MyNode node = stack.Last();
                stack.RemoveLast();
                Console.Write(node.data + " ");
                if (node.left != null)
                    stack.AddFirst(node.left);
                if (node.right != null)
                    stack.AddFirst(node.right);
             
               
            }
            
        }

        public void iterativePreOrder(MyNode objRoot)
        {
            Stack<MyNode> stack = new Stack<MyNode>();
            List<int> lst = new List<int>();
            if (objRoot == null)
                Console.Write(" ");

            stack.Push(objRoot);
            while (stack.Count > 0)
            {
                MyNode node = stack.Peek();
            
                Console.Write(node.data + " ");
                stack.Pop();
                if (node.right != null)
                    stack.Push(node.right);
                if (node.left != null)
                    stack.Push(node.left);


            }
          

        }
        public void iterativeInOrder(MyNode objRoot)
        {
            Stack<MyNode> stack = new Stack<MyNode>();
            List<int> lst = new List<int>();
            if (objRoot == null)
                Console.Write(" ");

            stack.Push(objRoot);
            while (stack.Count > 0)
            {
                MyNode node = stack.Peek();
                if (node.right != null)
                    stack.Push(node.right);
                Console.Write(node.data + " ");
                stack.Pop();
                if (node.left != null)
                    stack.Push(node.left);


            }


        }
    }
}
