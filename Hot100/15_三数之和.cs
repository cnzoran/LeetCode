using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/3sum/

    internal class _15_三数之和
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);

            IList<IList<int>> list = new List<IList<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }

                int cur = nums[i];

                int left = i + 1;
                int right = nums.Length - 1;

                while (left < right)
                {
                    if (left > i + 1 && nums[left] == nums[left - 1])
                    {
                        left++;
                        continue;
                    }
                    if (right < nums.Length - 1 && nums[right] == nums[right + 1])
                    {
                        right--;
                        continue;
                    }

                    int sum = cur + nums[left] + nums[right];
                    if (sum > 0)
                    {
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        list.Add(new List<int> { cur, nums[left], nums[right] });
                        left++;
                        right--;
                    }
                }
            }

            return list;
        }

        public void Test()
        {
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> ans = ThreeSum(nums);

            for (int i = 0; i < ans.Count; i++)
            {
                Console.WriteLine(string.Join(",", ans[i]));
            }
        }
    }
}
