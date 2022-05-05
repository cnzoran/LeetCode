using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/linked-list-cycle-ii/
    public class _142_环形链表II
    {
        /*
         * 设链表中环外部分的长度为 a。slow 指针进入环后，又走了 b 的距离与 fast 相遇。
         * 相遇位置到环的起始点距离为 c，即 b + c = 环长度。
         * 此时，fast 指针已经走完了环的 n 圈，因此它走过的总距离为
         * a + n * (b + c) + b = a + (n + 1) * b + n * c
         * 根据题意，任意时刻，fast 指针走过的距离都为 slow 指针的 2 倍。因此，我们有
         * a + (n + 1) * b + n * c = 2 * (a + b) = 2 * a + 2 * b
         * ⟹ n * b + b + n * c = a + 2 * b
         * ⟹ n * b + n * c = a + b
         * ⟹ a = n * b - b + n * c
         * ⟹ a = c + (n − 1) * (b + c)
         * b + c 为环长，可知：
         * 从相遇点到入环点的距离加上 n−1 圈的环长，恰好等于从链表头部到入环点的距离。
         * 因此，当发现 slow 与 }fast 相遇时，使 slow 指向链表头部；
         * 随后，它和 fast 每次向后移动一位。
         * 最终，它们会在入环点相遇。
         */
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null)
                return null;
            
            ListNode slow = head, fast = head;
            while (fast != null)
            {
                slow = slow.next;
                
                if (fast.next is null)
                    return null;
                
                fast = fast.next.next;

                if (slow == fast)
                    break;
            }

            if (fast is null)
                return null;

            slow = head;
            while (slow != fast)
            {
                slow = slow.next;
                fast = fast.next;
            }
            return slow;
        }
    }
}
