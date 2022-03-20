using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/valid-parentheses/

    class _20_有效的括号
    {
        public bool IsValid(string s)
        {
            char[] chars = s.ToCharArray();
            if (chars.Length % 2 != 0)
            {
                return false;
            }

            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('}', '{');
            dic.Add(']', '[');
            dic.Add(')', '(');

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < chars.Length; i++)
            {
                char c = chars[i];
                if (dic.ContainsKey(c))
                {
                    if (stack.Count == 0 || stack.Peek() != dic.GetValueOrDefault(c, ' '))
                        return false;
                    stack.Pop();
                }
                else
                {
                    stack.Push(c);
                }
            }

            return stack.Count == 0;
        }

        public void Test()
        {
            Console.WriteLine(IsValid("()[{()}]"));
        }
    }
}
