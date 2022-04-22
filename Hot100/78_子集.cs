using System;
using System.Collections.Generic;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/subsets/
    public class _78_子集
    {
        public IList<IList<int>> Subsets(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            Backtracking(0, nums.Length, nums, new List<int>(), ans);
            return ans;
        }

        void Backtracking(int curIndex, int totalLen, int[] nums, List<int> list, IList<IList<int>> ans)
        {
            ans.Add(new List<int>(list));

            for (int i = curIndex; i < totalLen; i++)
            {
                list.Add(nums[i]);
                Backtracking(i + 1, totalLen, nums, list, ans);
                list.Remove(nums[i]);
            }
        }

        public void Test()
        {
            int[] nums = { 1, 2, 3 };
            IList<IList<int>> ans = Subsets(nums);
            foreach (IList<int> list in ans)
            {
                Console.WriteLine(string.Join(",", list));
            }
        }
    }
}