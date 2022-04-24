using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/validate-binary-search-tree/
    internal class _98_验证二叉搜索树
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, long.MinValue, long.MaxValue);
        }
        
        private bool IsValidBST(TreeNode root, long lower, long upper)
        {
            if (root == null)
            {
                return true;
            }
            if (root.val <= lower || root.val >= upper)
            {
                return false;
            }
            return IsValidBST(root.left, lower, root.val) && IsValidBST(root.right, root.val, upper);
        }

        public void Test()
        {
            var root = new TreeNode(2)
            {
                left = new TreeNode(1),
                right = new TreeNode(3)
            };
            Console.WriteLine(IsValidBST(root));
        }
    }
}
