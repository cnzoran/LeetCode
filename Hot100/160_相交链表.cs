using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/intersection-of-two-linked-lists/

    class _160_相交链表
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> hashset = new HashSet<ListNode>();

            while (headA != null || headB != null)
            {
                if (headA != null)
                {
                    if (!hashset.Add(headA))
                    {
                        return headA;
                    }
                    headA = headA.next;
                }

                if (headB != null)
                {
                    if (!hashset.Add(headB))
                    {
                        return headB;
                    }
                    headB = headB.next;
                }
            }

            return null;
        }

        //官方最优解：双指针
        public ListNode GetIntersectionNode_1(ListNode headA, ListNode headB)
        { 
            if (headA == null || headB == null) 
            {
                return null;
            }
            ListNode pA = headA, pB = headB;
            while (pA != pB) {
                pA = pA == null ? headB : pA.next;
                pB = pB == null ? headA : pB.next;
            }
            return pA;
        }

        public void Test()
        {
            ListNode headA = new ListNode(1);
            headA.next = new ListNode(9);
            headA.next.next = new ListNode(1);
            headA.next.next.next = new ListNode(2);
            headA.next.next.next.next = new ListNode(4);

            ListNode headB = new ListNode(3);
            headB.next = headA.next.next.next;//new ListNode(2);
            //headB.next.next = new ListNode(4);
            //headB.next.next.next = headA.next.next;

            ListNode ans = GetIntersectionNode_1(headA, headB);
            List<int> list = new List<int>();
            while (ans != null)
            {
                list.Add(ans.val);
                ans = ans.next;
            }
            Console.WriteLine(string.Join(",", list));
        }
    }
}
