using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    internal class _114_二叉树展开为链表
    {
        /*
        给你二叉树的根结点 root ，请你将它展开为一个单链表：
        展开后的单链表应该同样使用 TreeNode ，其中 right 子指针指向链表中下一个结点，而左子指针始终为 null 。
        展开后的单链表应该与二叉树 先序遍历 顺序相同。
        示例 1：
        输入：root = [1,2,5,3,4,null,6]
        输出：[1,null,2,null,3,null,4,null,5,null,6]
         */
        //https://leetcode-cn.com/problems/flatten-binary-tree-to-linked-list/
        public void Flatten(TreeNode root)
        {
            while (root != null)
            {
                if (root.left != null)
                {
                    TreeNode next = root.left;
                    TreeNode predecessor = next;
                    while (predecessor.right != null)
                    {
                        predecessor = predecessor.right;
                    }
                    predecessor.right = root.right;
                    root.left = null;
                    root.right = next;
                }
                root = root.right;
            }
        }
    }
}
