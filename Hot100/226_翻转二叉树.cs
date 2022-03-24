using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    class _226_翻转二叉树
    {
        //https://leetcode-cn.com/problems/invert-binary-tree/

        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }

            TreeNode left = InvertTree(root.left);
            TreeNode right = InvertTree(root.right);
            root.left = right;
            root.right = left;

            return root;
        }

        public void Test()
        {
            TreeNode root = new TreeNode(4);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(1);
            root.left.right = new TreeNode(3);
            root.right = new TreeNode(7);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(9);

            TreeNode ans = InvertTree(root);

            List<int> list = new List<int>();
            list.Add(ans.val);
            PrintTree(ans, list);
            Console.WriteLine(string.Join(",", list));
        }

        private void PrintTree(TreeNode root, List<int> list)
        {
            if (root == null)
            {
                return;
            }
            if (root.left != null)
            {
                list.Add(root.left.val);
            }
            if (root.right != null)
            {
                list.Add(root.right.val);
            }
            PrintTree(root.left, list);
            PrintTree(root.right, list);
        }
    }
}
