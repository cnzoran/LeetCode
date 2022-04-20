using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/group-anagrams/
    internal class _49_字母异位词分组
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            foreach (var item in strs)
            {
                char[] chars = item.ToCharArray();
                Array.Sort(chars);
                string key = new string(chars);
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(item);
                }
                else
                {
                    dict.Add(key, new List<string>() { item });
                }
            }

            dict.Values.ToList().ForEach(x => result.Add(x));

            return result;
        }

        public void Test()
        {
            IList<IList<string>> result = GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            foreach (var item in result)
            {
                Console.WriteLine(string.Join(",", item));
            }
        }
    }
}
