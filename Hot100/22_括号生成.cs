using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/generate-parentheses/

    internal class _22_括号生成
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> ans = new List<string>();
            Backtrack(ans, n, 0, 0, new StringBuilder());
            return ans;
        }

        private void Backtrack(IList<string> ans, int total, int ls, int rs, StringBuilder sb)
        {
            if (ls == total && rs == total)
            {
                ans.Add(sb.ToString());
                return;
            }

            if (ls < rs)
            {
                return;
            }

            if (ls < total)
            {
                sb.Append('(');
                Backtrack(ans, total, ls + 1, rs, sb);
                sb.Remove(sb.Length - 1, 1);
            }

            if (rs < total)
            {
                sb.Append(')');
                Backtrack(ans, total, ls, rs + 1, sb);
                sb.Remove(sb.Length - 1, 1);
            }
        }

        public void Test()
        {
            IList<string> ans = GenerateParenthesis(3);
            Console.WriteLine(string.Join(",", ans));
        }
    }
}
