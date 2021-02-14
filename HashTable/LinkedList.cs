using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    class LinkedList<K, V> where K : IComparable
    {
        public MyMapNode<K, V> Head;
        public MyMapNode<K, V> Tail;

        public LinkedList()
        {
            Head = null;
            Tail = null;
        }
        internal MyMapNode<K, V> Search(K key)
        {
            MyMapNode<K, V> temp = Head;
            while (temp != null)
            {
                if (temp.key.Equals(key))
                    return temp; ;
                temp = temp.next;
            }
            return null;
        }
        public void Append(MyMapNode<K, V> node)
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }
        public bool IsEmpty()
        {
            return Head == null && Tail == null;
        }

        public MyMapNode<K, V> Pop()
        {
            MyMapNode<K, V> temp = Head;
            if (Head != null)
            {
                Head = Head.next;
            }
            return temp;
        }

        public MyMapNode<K, V> PopLast()
        {
            MyMapNode<K, V> TailTemp = Tail;
            if (!IsEmpty())
            {
                MyMapNode<K, V> temp = Head;
                while (temp.next != Tail)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Tail = temp;
            }
            return TailTemp;
        }

        public bool DeleteNode(MyMapNode<K, V> DeleteNode)
        {

            MyMapNode<K, V> temp = Head;
            if (!IsEmpty())
            {
                if (DeleteNode.key.Equals(Head.key))
                {
                    Pop();
                    return true;
                }
                if (DeleteNode.key.Equals(Tail.key))
                {
                    PopLast();
                    return true;
                }
                while (temp != null)
                {
                    if (temp.next != null && temp.next.key.Equals(DeleteNode.key))
                    {
                        temp.next = DeleteNode.next;
                        return true;
                    }
                    temp = temp.next;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "" + Head + "";

        }
    }
}
