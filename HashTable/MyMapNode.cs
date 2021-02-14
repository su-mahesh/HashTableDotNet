using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class MyMapNode<K, V>{
        public K key;
        public V value;
        public MyMapNode<K, V> next;

    public MyMapNode(K key, V value)
    {
        this.key = key;
        this.value = value;
        next = null;
    }
   
    public override string ToString()
    {
        StringBuilder myMapNodeString = new StringBuilder();
        myMapNodeString.Append("MyMapNode{" + "K = ").Append(key).Append(" V = ").Append(value).Append("}");
        if (next != null)
            myMapNodeString.Append("-> ").Append(next);
        return myMapNodeString.ToString();

    }
}
}
