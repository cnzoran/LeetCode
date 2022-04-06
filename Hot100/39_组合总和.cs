using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/combination-sum/
    
    internal class _39_组合总和
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates, (x, y) =>
            {
                if (x == y) return 0;
                return x > y ? 1 : -1;
            });

            IList<IList<int>> result = new List<IList<int>>();
            Dfs(candidates, 0, result, new List<int>(), target);

            return result;
        }

        private void Dfs(int[] candidates, int idx, IList<IList<int>> result, List<int> list, int target)
        {
            if (idx == candidates.Length) return;

            if (target == 0)
            {
                result.Add(new List<int>(list));
                return;
            }

            if (target - candidates[idx] < 0) return;  //剪枝
            
            Dfs(candidates, idx + 1, result, list, target);

            if (target >= candidates[idx])
            {
                list.Add(candidates[idx]);
                Dfs(candidates, idx, result, list, target - candidates[idx]);
                list.RemoveAt(list.Count - 1);
            }
        }

        public void Test()
        {
            int[] candidates = new int[] { 2, 3, 5 };
            IList<IList<int>> result = CombinationSum(candidates, 8);
            foreach (List<int> list in result)
            {
                Console.WriteLine(string.Join(",", list));
            }
        }
    }
}
