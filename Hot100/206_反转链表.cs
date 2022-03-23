using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/reverse-linked-list/

    class _206_反转链表
    {
        //迭代
        public ListNode ReverseList(ListNode head)
        {
            ListNode curr = head;
            ListNode prev = null;

            while (curr != null)
            {
                ListNode next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }

            return prev;
        }

        public void Test()
        {
            ListNode head = new ListNode(1,
                new ListNode(2,
                new ListNode(3,
                new ListNode(4,
                new ListNode(5)))));

            ListNode ans = ReverseList(head);
            List<int> ans_list = new List<int>();
            
            while (ans != null)
            {
                ans_list.Add(ans.val);
                ans = ans.next;
            }

            Console.WriteLine(string.Join(",", ans_list));
        }
    }
}
