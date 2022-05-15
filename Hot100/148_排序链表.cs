using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    public class _148_排序链表
    {
        public ListNode SortList(ListNode head)
        {
            List<ListNode> sort = new List<ListNode>();
            while (head != null)
            {
                sort.Add(head);
                head = head.next;
            }
            sort.Sort((a, b) => a.val.CompareTo(b.val));

            for (int i = 0; i < sort.Count - 1; i++)
            {
                sort[i].next = sort[i + 1];
            }
            sort[sort.Count - 1].next = null;
            return sort[0];
        }

        public ListNode SortList1(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            ListNode slow = head, fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode next = slow.next;
            slow.next = null;
            ListNode l1 = SortList(head);
            ListNode l2 = SortList(next);
            return Merge(l1, l2);
        }

        private ListNode Merge(ListNode head1, ListNode head2)
        {
            ListNode dummy = new ListNode(0);
            ListNode cur = dummy;
            while (head1 != null && head2 != null)
            {
                if (head1.val < head2.val)
                {
                    cur.next = head1;
                    head1 = head1.next;
                }
                else
                {
                    cur.next = head2;
                    head2 = head2.next;
                }
                cur = cur.next;
            }
            if (head1 != null)
                cur.next = head1;
            if (head2 != null)
                cur.next = head2;
            return dummy.next;
        }
    }
}
