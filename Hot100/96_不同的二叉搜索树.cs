using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/unique-binary-search-trees/
    internal class _96_不同的二叉搜索树
    {
        public int NumTrees(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;
            dp[1] = 1;
            
            for (int i = 2; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    dp[i] += dp[j - 1] * dp[i - j];
                }
            }
            return dp[n];
        }

        public void Test()
        {
            Console.WriteLine(NumTrees(3));
        }
    }
}
