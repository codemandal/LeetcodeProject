using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class SNode
    {
        public int val;
        public SNode next;
        public SNode(int v)
        {
            this.val = v;
            this.next = null;
        }

        public void Print()
        {
            Console.Write("|" + val + "->");
            if (next != null)
            {
                next.Print();
            }
        }

        public void AddToEnd(int data)
        {
            if (next == null)
                next = new SNode(data);
            else
                next.AddToEnd(data);
        }

        public void AddSorted(int data)
        {
            if (next == null)
                next = new SNode(data);
            else if (data < next.val)
            {
                SNode temp = new SNode(data);
                temp.next = this.next;
                this.next = temp;

            }

        }

    }

    public class MyCustomLinkedList
    {
        public SNode headNode;

        public MyCustomLinkedList()
        {
            headNode = null;
        }

        public void AddToEnd(int data)
        {
            if (headNode == null)
                headNode = new SNode(data);
            else
                headNode.AddToEnd(data);

        }

        public void AddToBeginning(int data)
        {
            if (headNode == null)
                headNode = new SNode(data);
            else
            {
                SNode temp = new SNode(data);
                temp.next = headNode;
                headNode = temp;
                
            }
        }
        public void Print()
        {
            Console.Write("|" + headNode.val + "|->");
            if (headNode != null)
                headNode.next.Print();
        }

    }
}
