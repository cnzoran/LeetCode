using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/container-with-most-water/

    internal class _11_盛最多水的容器
    {
        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int max = 0;

            while (left < right)
            {
                int area = (right - left) * Math.Min(height[left], height[right]);
                max = Math.Max(area, max);

                if (height[left] > height[right])
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return max;
        }

        public void Test()
        {
            int[] height = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int ans = MaxArea(height);
            Console.WriteLine(ans);
        }
    }
}
