using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/climbing-stairs/

    class _70_爬楼梯
    {
        public int ClimbStairs(int n)
        {
            if (n < 1)
            {
                return 1;
            }

            //动态规划，f(x) = f(x - 2) + f(x - 1)

            int prepre = 0, pre = 0, cur = 1;
            for (int i = 1; i <= n; i++)
            {
                prepre = pre;
                pre = cur;
                cur = prepre + pre;
            }

            return cur;
        }

        public void Test()
        {
            Console.WriteLine(ClimbStairs(2));
        }
    }
}
