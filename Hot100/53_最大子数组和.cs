using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/maximum-subarray/

    class _53_最大子数组和
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0], preMax = max;

            for (int i = 1; i < nums.Length; i++)
            {
                preMax = preMax + nums[i] < nums[i] ? nums[i] : preMax + nums[i];
                max = Math.Max(max, preMax);
            }

            return max;
        }

        public void Test()
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int ans = MaxSubArray(nums);
            Console.WriteLine(ans);
        }
    }
}
