using System;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/hamming-distance/

    class _461_汉明距离
    {
        //逻辑异或运算符 ^
        //x和y相同位置取值相同时则位0，不同为1
        public int HammingDistance(int x, int y) 
        {
            int z = x ^ y, count = 0;

            while (z > 0)
            {
                count += z & 1;
                z >>= 1;
            }
            return count;
        }
        internal void Test()
        {
            int ans = HammingDistance(1, 4);
            Console.WriteLine(ans);
        }
    }
}