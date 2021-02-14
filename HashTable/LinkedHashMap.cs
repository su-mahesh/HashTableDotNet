using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class LinkedHashMap<K, V> where K : IComparable
    {
        private readonly int NumBuckets;
        readonly List<LinkedList<K, V>> BucketList;

    public LinkedHashMap(int NumBuckets)
    {
        this.NumBuckets = NumBuckets;
        BucketList = new List<LinkedList<K, V>>(NumBuckets);

        for (int i = 0; i < this.NumBuckets; i++)
        BucketList.Add(null);
    }
        public V Get(K key)
    {
        int index = GetBucketIndex(key);
        LinkedList<K, V> myLinkedList = BucketList[index];
        if (myLinkedList == null)
            return default;
        MyMapNode<K, V> myMapNode = myLinkedList.Search(key);
        return (myMapNode == null) ? default : myMapNode.value;
    }

    private int GetBucketIndex(K key)
    {
        int hashCode = Math.Abs(key.GetHashCode());
        int index = hashCode % NumBuckets;
        return index;
    }

    public void Add(K key, V value)
    {
        int index = this.GetBucketIndex(key);
        LinkedList<K,V> myLinkedList = BucketList[index];

        if (myLinkedList == null)
        {
            myLinkedList = new LinkedList<K, V>();
            BucketList[index] =  myLinkedList;
        }
        MyMapNode<K, V> myMapNode = myLinkedList.Search(key);
        if (myMapNode == null)
        {
            myMapNode = new MyMapNode<K, V>(key, value);
            myLinkedList.Append(myMapNode);
        }
        else myMapNode.value = value;
    }

    public override string ToString()
    {
        StringBuilder myMapNodeString = new StringBuilder("");
        foreach (var item in BucketList)
        {
            if (item != null)
            {
                myMapNodeString.Append("\nindex " + BucketList.IndexOf(item) + " : " + item);
            }        
        }
            return myMapNodeString.ToString();
    }
}
}
