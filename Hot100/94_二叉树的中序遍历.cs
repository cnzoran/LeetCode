using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/binary-tree-inorder-traversal/

    class _94_二叉树的中序遍历
    {
        //二叉树的中序遍历：按照访问左子树——根节点——右子树的方式遍历这棵树，而在访问左子树或者右子树的时候我们按照同样的方式遍历，直到遍历完整棵树。
        public List<int> InorderTraversal(TreeNode root)
        {
            List<int> ans = new List<int>();

            InorderTraversal(root, ans);

            return ans;
        }

        private void InorderTraversal(TreeNode root, List<int> ans)
        {
            if (root == null)
            {
                return;
            }

            InorderTraversal(root.left, ans);
            ans.Add(root.val);
            InorderTraversal(root.right, ans);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
