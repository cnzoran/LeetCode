using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/move-zeroes/

    class _283_移动零
    {
        public void MoveZeroes(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[count++] = nums[i];
                }
            }

            count = nums.Length - count;
            while (count > 0)
            {
                nums[nums.Length - count--] = 0;
            }

            Console.WriteLine(string.Join(",", nums));
        }

        //官解，我感觉理解程度并没上面的好
        public void MoveZeroes1(int[] nums)
        {
            int left = 0, right = 0;

            while (right < nums.Length)
            {
                if (nums[right] != 0)
                {
                    Swap(nums, left, right);
                    left++;
                }
                right++;
            }
        }

        public void Swap(int[] nums, int left, int right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }

        public void Test()
        {
            MoveZeroes(new int[] { 0, 1, 0, 3, 12 });
        }
    }
}
