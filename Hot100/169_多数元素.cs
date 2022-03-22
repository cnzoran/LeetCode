using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/majority-element/

    class _169_多数元素
    {
        public int MajorityElement(int[] nums)
        {
            //过半数组，那么排序之后中位数处的值一定是想要的解
            Array.Sort(nums);
            return nums[nums.Length >> 1];
        }

        //TODO:考虑分治法求解


        public void Test()
        {
            Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));
        }
    }
}
