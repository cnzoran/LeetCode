using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    class _141_环形链表
    {
        //https://leetcode-cn.com/problems/linked-list-cycle/

        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }

            //快慢指针，龟兔赛跑的思想
            ListNode slow = head;
            ListNode fast = head.next; 

            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    return false;
                }

                slow = slow.next;
                fast = fast.next.next;
            }

            return true;
        }

        public void Test()
        {
            ListNode listNode = new ListNode(3);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(0);
            listNode.next.next.next = new ListNode(-4, listNode.next);

            Console.WriteLine(HasCycle(listNode));
        }
    }
}
