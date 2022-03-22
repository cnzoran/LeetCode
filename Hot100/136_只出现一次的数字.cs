using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/single-number/

    class _136_只出现一次的数字
    {
        public int SingleNumber(int[] nums)
        {
            //位运算相关知识点学习
            //数组中的全部元素的异或运算结果即为数组中只出现一次的数字
            int ans = 0;
            foreach (int e in nums)
                ans ^= e;

            return ans;
        }

        public void Test()
        {
            Console.WriteLine(SingleNumber(new int[] { 1, 2, 3, 4, 5, 6, 5, 4, 3, 2, 1 }));
        }
    }
}
