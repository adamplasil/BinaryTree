using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class Dictionary<K, L>
    {
        internal class Node
        {
            public K Key { get; set; }
            public L Value { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }
        }
        public Node Root { get; set; }
        public Dictionary()
        {
            Root = null;
            Root.Left = Root.Right = null;
        }
        public void Add(K key, L value)
        {
            var Addnode = new Node()
            {
                Key = key,
                Value = value
                
            };
            if (Root == null)
            {
                Root = Addnode;
            }
            else if (Root.Key.Equals(key))
            {
                throw new Exception("");
            }
            else
            {
                if (key.ToString().CompareTo(Root.Key.ToString()) < 0)
                {
                    if (Root.Left == null)
                    {
                        Root.Left = Addnode;
                    }
                    else
                    {
                        Insert(Root, Addnode);
                    }
                }
            }
        }
        public void Insert (Node newroot, Node newnode)
        {
            if (newroot.Key.Equals(newnode.Key))
            {
                throw new Exception("");
            }
            else
            if (newroot.ToString().CompareTo(newnode.Key.ToString()) <0 )
            {
                if (newroot.Left == null)
                {
                    newroot.Left = newnode;
                }
                else
                 if (newroot.Right == null)
                 {
                    newroot.Right = newnode;
                 }
                else Insert(newnode.Left, newnode);
            }

                    
              
        }
        public override string ToString()
        {
            string retString = "";
            Node temp = Root;
            if (temp.Key !=null)
            {
                retString = retString + ToString(temp.Left);
                retString = retString + Root.Value.ToString();
            }
            return retString;
        }
        public string ToString(Node node)
        {
            return node.ToString();
        }
    }
}
