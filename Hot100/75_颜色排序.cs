using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/sort-colors/
    internal class _75_颜色排序
    {
        public void SortColors(int[] nums)
        {
            (int left, int right) = (0, nums.Length - 1);
            for (int i = 0; i <= right; i++)
            {                
                while (i <= right && nums[i] == 2)
                {
                    nums[i] = nums[right];
                    nums[right--] = 2;
                }
                if (nums[i] == 0)
                {
                    nums[i] = nums[left];
                    nums[left++] = 0;
                }
            }
        }

        public void Test()
        {
            int[] nums = { 2, 0, 1 };
            SortColors(nums);
            Console.WriteLine(string.Join(",", nums));
        }
    }
}
