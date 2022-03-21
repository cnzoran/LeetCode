using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/best-time-to-buy-and-sell-stock/

    class _121_买卖股票的最佳时机
    {
        public int MaxProfit(int[] prices)
        {
            int len = prices.Length;
            if (len < 2)
            {
                return 0;
            }

            // dp[i][0] 下标为 i 这天结束的时候，不持股，手上拥有的现金数
            // dp[i][1] 下标为 i 这天结束的时候，持股，手上拥有的现金数
            int[,] dp = new int[len, 2];

            dp[0, 0] = 0;
            dp[0, 1] = -prices[0];

            for (int i = 1; i < len; i++)
            {
                //前一天没买 or 前一天买了且今天卖了
                dp[i,0] = Math.Max(dp[i - 1,0], dp[i - 1,1] + prices[i]);
                //前一天买了今天不卖 or 前一天没买今天买
                dp[i,1] = Math.Max(dp[i - 1,1], -prices[i]);
            }

            return dp[len - 1,0];
        }

        //官方最优解
        public int maxProfit(int[] prices)
        {
            int minprice = int.MaxValue;
            int maxprofit = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minprice)
                {
                    minprice = prices[i];
                }
                else if (prices[i] - minprice > maxprofit)
                {
                    maxprofit = prices[i] - minprice;
                }
            }
            return maxprofit;
        }

        public void Test()
        {
            int[] prices1 = new int[] { 7, 1, 5, 3, 6, 4 };
            int[] prices2 = new int[] { 7, 6, 4, 3, 1 };
            Console.WriteLine(MaxProfit(prices1));
            Console.WriteLine(maxProfit(prices2));
        }
    }
}
