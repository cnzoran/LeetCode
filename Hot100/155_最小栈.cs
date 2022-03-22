using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    class _155_最小栈
    {
        Stack<int> m_stack;
        Stack<int> m_minStack;

        public _155_最小栈()
        {
            m_stack = new Stack<int>();
            m_minStack = new Stack<int>();
            m_minStack.Push(int.MaxValue);
        }

        public void Push(int val)
        {
            m_stack.Push(val);
            m_minStack.Push(Math.Min(m_minStack.Peek(), val));
        }

        public void Pop()
        {
            m_stack.Pop();
            m_minStack.Pop();
        }

        public int Top()
        {
            return m_stack.Peek();
        }

        public int GetMin()
        {
            return m_minStack.Peek();
        }
    }
}
