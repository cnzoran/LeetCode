using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    class _234_回文链表
    {
        public bool IsPalindrome(ListNode head)
        {
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            while (head != null)
            {
                stack.Push(head.val);
                queue.Enqueue(head.val);
                head = head.next;
            }

            while (stack.Count != 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    return false;
                }
            }

            return true;
        }

        public void Test()
        {
            ListNode head = new ListNode(1,
                new ListNode(2,
                new ListNode(2,
                new ListNode(1))));

            Console.WriteLine(IsPalindrome(head));
        }
    }
}
