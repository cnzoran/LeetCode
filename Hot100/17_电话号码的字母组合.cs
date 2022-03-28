using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/letter-combinations-of-a-phone-number/

    internal class _17_电话号码的字母组合
    {
        Dictionary<char, string> m_dic = new Dictionary<char, string>
        {
            {'2', "abc"},
            {'3', "def"},
            {'4', "ghi"},
            {'5', "jkl"},
            {'6', "mno"},
            {'7', "pqrs"},
            {'8', "tuv"},
            {'9', "wxyz"},
        };

        public IList<string> LetterCombinations(string digits)
        {
            if (string.IsNullOrEmpty(digits))
                return new List<string>();

            IList<string> ans = new List<string>();

            char[] chars = digits.ToCharArray();

            Traceback(ans, chars, 0, chars.Length, new StringBuilder());

            return ans;
        }

        private void Traceback(IList<string> ans, char[] chars, int index, int length, StringBuilder sb)
        {
            if (index == length)
            {
                ans.Add(sb.ToString());
                return;
            }

            char c = chars[index];
            if (!m_dic.ContainsKey(c))
            {
                return;
            }

            string s = m_dic[c];
            char[] cs = s.ToCharArray();

            for (int i = 0; i < cs.Length; i++)
            {
                sb.Append(cs[i]);
                Traceback(ans, chars, index + 1, length, sb);
                sb.Remove(index, 1);
            }
        }

        public void Test()
        {
            IList<string> ans = LetterCombinations("234");
            Console.WriteLine(string.Join(",", ans));
        }
    }
}
