using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/diameter-of-binary-tree/

    class _543_二叉树的直径
    {
        int m_ans = 0;

        public int DiameterOfBinaryTree(TreeNode root)
        {
            DFS(root);
            return m_ans;
        }

        public int DFS(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = DFS(root.left);
            int right = DFS(root.right);

            m_ans = Math.Max(m_ans, left + right);
            return Math.Max(left, right) + 1;
        }

        public void Test()
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2, new TreeNode(4), new TreeNode(5));
            root.right = new TreeNode(3);
            Console.WriteLine(DiameterOfBinaryTree(root));
        }
    }
}
