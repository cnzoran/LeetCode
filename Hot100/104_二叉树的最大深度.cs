using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/maximum-depth-of-binary-tree/

    class _104_二叉树的最大深度
    {
        //dfs
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                int left = MaxDepth(root.left);
                int right = MaxDepth(root.right);
                return Math.Max(left, right) + 1;
            }
        }

        public void Test()
        {
/**
              3
             / \
            9  20
              /  \
             15   7
**/
            TreeNode root = new TreeNode(3, new TreeNode(9),
                new TreeNode(20, new TreeNode(15), new TreeNode(7)));
            
            Console.WriteLine(MaxDepth(root));
        }
    }
}
