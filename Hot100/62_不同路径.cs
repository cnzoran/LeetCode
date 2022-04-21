using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/unique-paths/
    internal class _62_不同路径
    {
        public int UniquePaths(int m, int n)
        {
            //f(m,n) = f(m-1,n) + f(m,n-1)
            int[,] dp = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        dp[i, j] = 1;
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                    }
                }
            }

            return dp[m - 1, n - 1];
        }

        public int UniquePaths2(int m, int n)
        {
            int[] dp = new int[n - 1];
            
            for (int i = 0; i < m - 1; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    dp[j] = (j == 0 ? 1 : dp[j - 1]) + (i == 0 ? 1 : dp[j]);
                }
            }

            return dp[n - 2];
        }

        public void Test()
        {
            Console.WriteLine(UniquePaths2(3, 2));
        }
    }
}
