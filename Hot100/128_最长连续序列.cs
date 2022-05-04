using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/longest-consecutive-sequence/
    public class _128_最长连续序列
    {
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length == 0) return 0;
            HashSet<int> set = new();
            
            //利用HashSet的特性去重
            foreach (int num in nums)
            {
                set.Add(num);
            }
            
            int max = 0;
            foreach (int num in nums)
            {
                /*
                 * 跳过不必要的遍历
                 * 要枚举的数 x 一定是在数组中不存在前驱数 x-1 的，
                 * 不然按照分析会从 x−1 开始尝试匹配，因此我们每次在哈希表中检查是否存在 x-1 即能判断是否需要跳过了。
                 */
                if (!set.Contains(num - 1))
                {
                    int cur = num;
                    int count = 1;
                    while (set.Contains(cur + 1))
                    {
                        cur++;
                        count++;
                    }
                    max = Math.Max(max, count);
                }
            }
            return max;
        }
    }
}
