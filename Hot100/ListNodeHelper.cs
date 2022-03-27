using System;
using System.Collections.Generic;

namespace LeetCode.Hot100
{
    class ListNodeHelper
    {
        public static void ListNodePrint(ListNode listNode)
        {
            List<int> list = new List<int>();
            while (listNode != null)
            {
                list.Add(listNode.val);
                listNode = listNode.next;
            }

            Console.WriteLine(string.Join(",", list));
        }

        public static ListNode ListNodeCreate(int[] nums)
        {
            ListNode head = null, tail = null;
            for (int i = 0; i < nums.Length; i++)
            {
                if (head == null)
                {
                    head = tail = new ListNode(nums[i]);
                }
                else
                {
                    tail = tail.next = new ListNode(nums[i]);
                }

            }
            return head;
        }

        internal void Test()
        {
        }
    }
}