using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    //https://leetcode-cn.com/problems/symmetric-tree/

    class _101_对称二叉树
    {
        public bool IsSymmetric(TreeNode root)
        {
            return Recursion(root, root);
        }

        //递归
        public bool Recursion(TreeNode ls, TreeNode rs)
        {
            if (ls == null && rs == null)
            {
                return true;
            }

            if (ls == null || rs == null)
            {
                return false;
            }

            return ls.val == rs.val && Recursion(ls.left, rs.right) && Recursion(ls.right, rs.left);
        }

        //迭代
        public bool Iteration(TreeNode ls, TreeNode rs)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(ls);
            queue.Enqueue(rs);

            while (queue.Count != 0)
            {
                ls = queue.Dequeue();
                rs = queue.Dequeue();

                if (ls == null && rs == null)
                {
                    continue;
                }

                if (ls == null || rs == null)
                {
                    return false;
                }

                if (ls.val != rs.val)
                {
                    return false;
                }

                queue.Enqueue(ls.left);
                queue.Enqueue(rs.right);

                queue.Enqueue(ls.right);
                queue.Enqueue(rs.left);
            }

            return true;
        }
    }
}
