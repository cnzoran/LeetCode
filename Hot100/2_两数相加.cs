using System;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/add-two-numbers/
    
    class _2_两数相加
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode head = null, tail = null;
            int digit = 0;
            while (l1 != null || l2 != null)
            {
                int val1 = l1 != null ? l1.val : 0;
                int val2 = l2 != null ? l2.val : 0;

                int sum = val1 + val2 + digit;
                if (head == null)
                {
                    head = tail = new ListNode(sum % 10);
                }
                else
                {
                    tail = tail.next = new ListNode(sum % 10);
                }

                digit = sum / 10;

                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }

            if (digit > 0)
            {
                tail.next = new ListNode(digit);
            }

            return head;
        }

        internal void Test()
        {
            ListNode l1 = ListNodeHelper.ListNodeCreate(new int[] { 2, 4, 3 });
            ListNode l2 = ListNodeHelper.ListNodeCreate(new int[] { 5, 6, 4 });
            ListNode ans = AddTwoNumbers(l1, l2);

            ListNodeHelper.ListNodePrint(ans);
        }
    }
}