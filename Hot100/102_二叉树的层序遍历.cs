using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/binary-tree-level-order-traversal/
    internal class _102_二叉树的层序遍历
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> ans = new List<IList<int>>();
            if (root == null) return ans;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                IList<int> level = new List<int>();
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                }
                ans.Add(level);
            }
            return ans;
        }

        public void Test()
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            IList<IList<int>> ans = LevelOrder(root);
            foreach (IList<int> item in ans)
            {
                Console.WriteLine(string.Join(",", item));
            }
        }
    }
}
