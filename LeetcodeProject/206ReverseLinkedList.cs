using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
     public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
         }
  }
    public class _206ReverseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            ListNode prev = null;
            ListNode cur = head;
            while (cur != null)
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
