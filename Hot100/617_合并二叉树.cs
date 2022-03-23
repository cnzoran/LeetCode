using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/merge-two-binary-trees/

    class _617_合并二叉树
    {
        //dfs
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null)
            {
                return root2;
            }
            if (root2 == null)
            {
                return root1;
            }

            TreeNode merged = new TreeNode(root1.val + root2.val);
            merged.left = MergeTrees(root1.left, root2.left);
            merged.right = MergeTrees(root1.right, root2.right);

            return merged;
        }
    }
}
