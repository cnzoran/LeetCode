using System;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/longest-palindromic-substring/

    class _5_最长回文子串
    {
        public string LongestPalindrome(string s)
        {
            char[] chars = s.ToCharArray();
            int n = chars.Length;
            string ans = Convert.ToString(chars[0]);

            bool[,] dp = new bool[n, n];

            for (int L = 1; L <= n; L++)
            {
                for (int i = 0; i <= n - L; i++)
                {
                    int right = i + L - 1;
                    if (chars[i] != chars[right])
                    {
                        dp[i, right] = false;
                    }
                    else
                    {
                        //aba --> right - i < 3
                        if (right - i < 3)
                        {
                            dp[i, right] = true;
                        }
                        else
                        {
                            dp[i, right] = dp[i + 1, right - 1];
                        }
                    }

                    if (dp[i, right] && ans.Length < L)
                    {
                        ans = s.Substring(i, L);
                    }
                }
            }

            return ans;
        }

        internal void Test()
        {
            Console.WriteLine(LongestPalindrome("cbbd"));
        }
    }
}