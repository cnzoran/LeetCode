using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/merge-intervals/
    internal class _56_合并区间
    {
        public int[][] Merge(int[][] intervals)
        {
            intervals = intervals.OrderBy(x => x[0]).ToArray();
            List<int[]> result = new List<int[]>();
            int[] current = intervals[0];
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= current[1])
                {
                    current[1] = Math.Max(current[1], intervals[i][1]);
                }
                else
                {
                    result.Add(current);
                    current = intervals[i];
                }
            }
            result.Add(current);
            return result.ToArray();
        }

        public void Test()
        {
            int[][] intervals = new int[][] { 
                new int[] { 1, 3 }, 
                new int[] { 2, 6 }, 
                new int[] { 8, 10 }, 
                new int[] { 15, 18 }
            };
            int[][] ans = Merge(intervals);
            foreach (var item in ans)
            {
                Console.WriteLine(item[0] + " " + item[1]);
            }
        }
    }
}
