using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/merge-two-sorted-lists/

    class _21_合并两个有序链表
    {
        //双指针迭代
        /** 
         时间复杂度：O(n+m)，
            其中 n 和 m 分别为两个链表的长度。
            因为每次循环迭代中，l1 和 l2 只有一个元素会被放进合并链表中， 
            因此 while 循环的次数不会超过两个链表的长度之和。
            所有其他操作的时间复杂度都是常数级别的，因此总的时间复杂度为 O(n+m)。

        空间复杂度：O(1)。我们只需要常数的空间存放若干变量。 
        **/
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode preHead = new ListNode(-1);
            ListNode prev = preHead;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }

                prev = prev.next;
            }
            // 合并后 l1 和 l2 最多只有一个还未被合并完，我们直接将链表末尾指向未合并完的链表即可
            prev.next = l1 == null ? l2 : l1;

            return preHead.next;
        }

        //递归
        /**
         时间复杂度：O(n+m)，其中 n 和 m 分别为两个链表的长度。
            因为每次调用递归都会去掉 l1 或者 l2 的头节点（直到至少有一个链表为空），
            函数 mergeTwoList 至多只会递归调用每个节点一次。
            因此，时间复杂度取决于合并后的链表长度，即 O(n+m)。

        空间复杂度：O(n+m)，其中 n 和 m 分别为两个链表的长度。
            递归调用 mergeTwoLists 函数时需要消耗栈空间，栈空间的大小取决于递归调用的深度。
            结束递归调用时 mergeTwoLists 函数最多调用 n+m 次，因此空间复杂度为 O(n+m)。
         **/
        public ListNode MergeTwoLists1(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }

        internal void Test()
        {
            ListNode l1 = new ListNode(1,
                new ListNode(2,
                new ListNode(4)));
            ListNode l2 = new ListNode(1,
                new ListNode(3,
                new ListNode(4)));

            ListNode ans = MergeTwoLists(l1, l2);
            while (ans != null)
            {
                Console.Write(ans.val + ", ");
                ans = ans.next;
            }
        }
    }

    public class ListNode
    {
        public ListNode next;
        public int val;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
