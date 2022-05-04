using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    public class _105_从前序与中序遍历序列构造二叉树
    {        
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            //preorder第一个一定是root节点
            TreeNode root = new TreeNode(preorder[0]);
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            int inorderIndex = 0;
            
            for (int i = 1; i < preorder.Length; i++)
            {
                int preorderValue = preorder[i];
                TreeNode node = stack.Peek();
                if (node.val != inorder[inorderIndex])
                {
                    node.left = new TreeNode(preorderValue);
                    stack.Push(node.left);
                }
                else
                {
                    while (stack.Count > 0 && stack.Peek().val == inorder[inorderIndex])
                    {
                        node = stack.Pop();
                        ++inorderIndex;
                    }
                    node.right = new TreeNode(preorderValue);
                    stack.Push(node.right);
                }
            }
            
            return root;
        }
    }
}
