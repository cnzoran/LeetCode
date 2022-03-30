using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/search-in-rotated-sorted-array/

    internal class _33_搜索旋转排序数组
    {
        public int Search(int[] nums, int target)
        {
            int n = nums.Length;
            if (n == 0)
                return -1;
            if (n == 1)
                return nums[0] == target ? 0 : -1;

            int left = 0, right = n - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                    return mid;

                if (nums[0] <= nums[mid])
                {
                    if (nums[0] <= target && nums[mid] > target)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                else
                {
                    if (nums[mid] < target && nums[n - 1] >= target)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid - 1;
                    }
                }
            }

            return -1;
        }

        public void Test()
        {
            int ans = Search(new int[] { 4, 5, 6, 7, 0, 1, 2 }, 0);
            Console.WriteLine(ans);
        }
    }
}
