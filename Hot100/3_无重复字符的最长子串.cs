using System;
using System.Collections.Generic;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/longest-substring-without-repeating-characters/

    class _3_无重复字符的最长子串
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            char[] chars = s.ToCharArray();

            int right = -1;
            int maxLen = 0;
            HashSet<char> hashSet = new HashSet<char>();

            for (int i = 0; i < n; i++)
            {
                if (i != 0)
                {
                    hashSet.Remove(chars[i - 1]);
                }
                while (right + 1 < n && !hashSet.Contains(chars[right + 1]))
                {
                    hashSet.Add(chars[++right]);
                }
                maxLen = Math.Max(maxLen, right - i + 1);
            }

            return maxLen;
        }
        internal void Test()
        {
            int ans = LengthOfLongestSubstring("abba");
            Console.WriteLine(ans);
        }
    }
}