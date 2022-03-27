using System;
using System.Collections.Generic;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/find-all-numbers-disappeared-in-an-array/
    
    class _448_找到所有数组中消失的数字
    {
        public List<int> FindDisappearedNumbers(int[] nums)
        {
            int n = nums.Length;

            foreach (int num in nums)
            {
                int x = (num - 1) % n;
                nums[x] += n;
            }

            List<int> ans = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (nums[i] <= n)
                {
                    ans.Add(i + 1);
                }
            }

            return ans;
        }

        internal void Test()
        {
            int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
            List<int> ans = FindDisappearedNumbers(nums);
            Console.WriteLine(string.Join(",", ans));
        }
    }
}