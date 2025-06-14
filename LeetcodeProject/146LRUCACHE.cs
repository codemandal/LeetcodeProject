using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProject
{
    public class LRUCache
    {
        private int _capacity;
        private Dictionary<int, Node> _keys = new Dictionary<int, Node>();
        private Dictionary<int, Node> _values = new Dictionary<int, Node>();

        Node _head;
        Node _tail;

        public LRUCache(int capacity)
        {
            _capacity = capacity;
        }

        public int Get(int key)
        {
            var node = _keys.GetValueOrDefault(key, null);
            if (node == null)
                return -1;

            Remove(node);
            Insert(node);

            return node.val;
        }

        public void Put(int key, int value)
        {
            var node = _keys.GetValueOrDefault(key, null);
            if (node == null)
            {
                if (_values.Count == _capacity)
                {
                    _keys.Remove(_tail.key);
                    Remove(_tail);
                }

                node = new Node { val = value, key = key };
                _keys.Add(key, node);
            }
            else
            {
                node.val = value;
                Remove(node);
            }

            Insert(node);
        }

        private void Insert(Node node)
        {
            node.nxt = _head;
            node.prv = null;
            if (_head != null) _head.prv = node;
            _head = node;
            if (node.nxt == null)
                _tail = node;
        }

        private void Remove(Node node)
        {
            var previous = node.prv;
            var next = node.nxt;

            if (previous != null)
                previous.nxt = next;

            if (next != null)
                next.prv = previous;

            node.prv = null;
            node.nxt = null;

            if (previous == null)
                _head = next;

            if (next == null)
                _tail = previous;
        }

        public class Node
        {
            public int key;
            public Node prv;
            public Node nxt;
            public int val;
        }

    }

 

  
}
