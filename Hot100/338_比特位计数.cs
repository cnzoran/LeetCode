using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/counting-bits/
    //solution https://leetcode-cn.com/problems/counting-bits/solution/bi-te-wei-ji-shu-by-leetcode-solution-0t1i/
    class _338_比特位计数
    {
        public int[] CountBits(int n)
        {
            int[] bits = new int[n + 1];
            for (int i = 0; i <= n; i++) {
                bits[i] = CountOnes(i);
            }
            return bits;
        }

        public int CountOnes(int x)
        {
            int ones = 0;
            while (x > 0) {
                x &= (x - 1);
                ones++;
            }
            return ones;
        }

        //动态规划
        /**
        
        **/
        public int[] ContBits_Dp(int n)
        {
            int[] bits = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                bits[i] = bits[i >> 1] + (i & 1);
            }
            return bits;
        }

        internal void Test()
        {
            int[] ans = ContBits_Dp(2);
            Console.WriteLine(string.Join(",", ans));
        }
    }
}
