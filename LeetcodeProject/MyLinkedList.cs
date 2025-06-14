using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

    public class MyLinkedList
    {
        public Node head;
        public int cnt;

        public MyLinkedList()
        {
            head = null;
            cnt = 0;
        }


        public void addAtHead(int d)
        {
            Node newNode = new Node(d);
            newNode.next = head;
            head = newNode;
            cnt++;
            
        }

        public void addAtTail(int d)
        {
            Node newNode = new Node(d);
            if (head == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                Node runner = head;
                while (runner.next != null)
                {
                    runner = runner.next;
                }
                newNode.next = runner.next;
                runner.next = newNode;
                cnt++;
            }
            
        
        }

        public void addAfterNode(Node nd, int d)
        {
            Node runner = head;
            while (runner.next != nd.next)
            {
                runner = runner.next;
            }
            Node newNode = new Node(d);
            newNode.next = nd.next;
            nd.next = newNode;
            cnt++;
        }

        public void printAllNode()
        {
            Node runner = head;
            while (runner != null)
            {
                Console.Write("|" + runner.data + "|->");
                runner = runner.next;
            
            }
            
        }

         public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode cur = head;
        while(cur != null)
        {
            ListNode temp = cur.next;
            cur.next = prev;
            prev = cur;
            cur = temp;
        }
        return prev;
    }

    }



}
