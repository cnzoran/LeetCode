using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/permutations/
    
    internal class _46_全排列
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> ans = new List<IList<int>>();

            List<int> output = new List<int>(nums);

            Backtrace(nums.Length, output, ans, 0);

            return ans;
        }

        private void Backtrace(int length, List<int> output, IList<IList<int>> ans, int first)
        {
            if (first == length)
            {
                ans.Add(new List<int>(output));
            }

            for (int i = first; i < length; i++)
            {
                Swap(output, first, i);
                Backtrace(length, output, ans, first + 1);
                Swap(output, first, i);
            }
        }

        private void Swap(List<int> output, int ls, int rs)
        {
            int valueLs = output[ls];
            output[ls] = output[rs];
            output[rs] = valueLs;
        }

        public void Test()
        {
            IList<IList<int>> ans = Permute(new int[] { 1, 2, 3 });
            foreach (IList<int> list in ans)
            {
                Console.WriteLine(string.Join(",", list));
            }
        }
    }
}
