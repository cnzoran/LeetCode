using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Hot100
{
    public class LRUCache
    {
        private Dictionary<int, int> _dic;
        private LinkedList<int> _list;
        private int _capacity;
        private Dictionary<int, LinkedListNode<int>> _dicNode;
        public LRUCache(int capacity)
        {
            _dic = new Dictionary<int, int>();
            _list = new LinkedList<int>();
            _capacity = capacity;
            _dicNode = new Dictionary<int, LinkedListNode<int>>();
        }

        public int Get(int key)
        {
            if (_dic.ContainsKey(key))
            {
                _list.Remove(key);
                _list.AddFirst(key);
                _dicNode[key] = _list.First;
                return _dic[key];
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (_dic.ContainsKey(key))
            {
                _list.Remove(key);
                _dicNode.Remove(key);
                _list.AddFirst(key);
                _dicNode[key] = _list.First;
                _dic[key] = value;
            }
            else
            {
                if (_dic.Count == _capacity)
                {
                    int last = _list.Last.Value;
                    _list.RemoveLast();
                    _dic.Remove(last);
                    _dicNode.Remove(last);
                }
                _list.AddFirst(key);
                _dicNode[key] = _list.First;
                _dic.Add(key, value);
            }
        }
    }
}
