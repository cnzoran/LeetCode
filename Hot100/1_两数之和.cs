using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/two-sum/

    class _1_两数之和
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int curValue = nums[i];

                if (dic.ContainsKey(target - curValue))
                {
                    return new int[] { dic[target - curValue], i };
                }

                if (!dic.ContainsKey(curValue))
                    dic.Add(curValue, i);
            }

            return new int[2];
        }

        public void Test()
        {
            int[] nums = new int[] { 2, 2, 7, 11, 15 };
            int[] ans = TwoSum(nums, 9);
            Console.WriteLine(string.Join(",", ans));
        }
    }
}
