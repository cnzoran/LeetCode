using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    //尝试二分解法
    internal class _34_在排序数组中查找元素的第一个和最后一个位置
    {
        public int[] SearchRange(int[] nums, int target)
        {            
            int head = 0, tail = nums.Length - 1;
            while (head < nums.Length && nums[head] != target)
                head++;
            while (tail >= 0 && nums[tail] != target)
                tail--;

            if (head >= 0 && head <= tail && tail < nums.Length && nums[head] == target && nums[tail] == target)
                return new int[] { head, tail };
            return new int[] { -1, -1 };
        }
        
        public void Test()
        {
            int[] nums = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 6;
            int[] result = SearchRange(nums, target);
            Console.WriteLine(String.Join(",", result));
        }
    }
}
