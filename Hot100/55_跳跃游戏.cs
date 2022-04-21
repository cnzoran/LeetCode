using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/jump-game/
    internal class _55_跳跃游戏
    {
        public bool CanJump(int[] nums)
        {
            int rs = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i <= rs)
                {
                    rs = Math.Max(rs, i + nums[i]);
                    if (rs >= nums.Length - 1)
                        return true;
                }
            }
            return false;
        }

        public void Test()
        {
            int[] nums = { 2, 3, 1, 1, 4 };
            Console.WriteLine(CanJump(nums));
        }
    }
}
