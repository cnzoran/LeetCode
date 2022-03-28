using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/remove-nth-node-from-end-of-list/

    internal class _19_删除链表的倒数第_N_个结点
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode tail = dummy;

            for (int i = 0; i < n; i++)
                head = head.next;

            while (head != null)
            {
                head = head.next;
                tail = tail.next;
            }

            tail.next = tail.next.next;

            return dummy.next;
        }

        public void Test()
        {
            ListNode head = ListNodeHelper.ListNodeCreate(new int[] { 1, 2, 3, 4, 5 });
            ListNode ans = RemoveNthFromEnd(head, 2);
            ListNodeHelper.ListNodePrint(ans);
        }
    }
}
