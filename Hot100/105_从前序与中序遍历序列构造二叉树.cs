using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    internal class _105_从前序与中序遍历序列构造二叉树
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder.Length == 0)
                return null;
            BuildTree(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
        }

        private TreeNode BuildTree(int[] preorder, int currPreorderLen, int preorderLen, int[] inorder, int currInorderLen, int inorderLen)
        {
            
        }
    }
}
