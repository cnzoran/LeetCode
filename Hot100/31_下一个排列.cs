using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/next-permutation/
    /**
        “下一个排列”的定义是：
        给定数字序列的字典序中下一个更大的排列。如果不存在下一个更大的排列，
        则将数字重新排列成最小的排列（即升序排列）。
        我们可以将该问题形式化地描述为：给定若干个数字，将其组合为一个整数。
        如何将这些数字重新排列，以得到下一个更大的整数。
        如 123 下一个更大的数为 132。如果没有更大的整数，则输出最小的整数。

        以 1,2,3,4,5,6 为例，其排列依次为： 
        123456
        123465
        123546
        ...
        654321
     **/

    internal class _31_下一个排列
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = nums.Length - 1;
                while (j >= 0 && nums[i] >= nums[j])
                {
                    j--;
                }

                Swap(nums, i, j);
            }

            Reverse(nums, i + 1);
        }

        private void Reverse(int[] nums, int start)
        {
            int left = start, right = nums.Length - 1;
            while (left < right)
            {
                Swap(nums, left, right);
                left++;
                right--;
            }
        }

        private void Swap(int[] nums, int left, int right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;

            Console.WriteLine(string.Join(",", nums));
        }

        public void Test()
        {
            NextPermutation(new int[] { 1, 2, 3 });
        }
    }
}
