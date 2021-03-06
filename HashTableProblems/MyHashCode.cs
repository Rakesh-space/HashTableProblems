using System;
using System.Collections.Generic;

namespace HashTable
{
    class MyHashCode<K, V>  //here main hashCode operation
    {
        public struct keyValue<K, V>  //here structure define for key and value 
        {
            public K key  //here getter and setter method used
            {
                get;
                set;
            }
            public V value  //here getter and setter method used
            {
                get;
                set;
            }

        }
        public readonly int size; //here size variable declare
        public readonly LinkedList<keyValue<K, V>>[] item; //here use linkedlist and array
        
        public MyHashCode(int size)  //here parametric constructore use
        {
            this.size = size;
            this.item = new System.Collections.Generic.LinkedList<keyValue<K, V>>[size];
        }

        protected int getArrayPosition(K key)  //here finding the array possition 
        {
            int possition = key.GetHashCode() % size;   //here formula to use gethashcode function
            return Math.Abs(possition);
        }

        public V get(K key)
        {
            int possition = getArrayPosition(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedList(possition);
            foreach (keyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    return item.value;
                }
            }
            return default(V);
        }

        public void Add(K key, V value)  //here user adding into linkedlist
        {
            int possition = getArrayPosition(key);
            LinkedList<keyValue<K, V>> LinkedList = GetLinkedList(possition);
            keyValue<K, V> item = new keyValue<K, V>();
            {
                key = key;
                value = value;
            }
            if (LinkedList.Count != 0)
            {
                foreach (keyValue<K, V> item1 in LinkedList)
                {
                    if (item.key.Equals(key))
                    {
                        Remove1(key);
                        removeSpecificWord(key);
                        break;
                    }
                }
            }
            LinkedList.AddLast(item);
        }

       
        public void Remove1(K key) //here if it is matched found ele in linked then remove that ele 
        {
            int possition = getArrayPossition(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedList(possition);
            bool itemFound = false;
            keyValue<K, V> founditem = default(keyValue<K, V>);
            foreach (keyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    itemFound = true;
                    founditem = item;
                }
            }
            if (itemFound)
            {
                linkedlist.Remove(founditem);
            }
        }

        public void removeSpecificWord(K word1) //here if it is matched found ele in linked then remove that ele 
        {
            int possition = getArrayPossition(word1);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedList(possition);
            bool itemFound = false;
            string words;
            keyValue<K, V> founditem = default(keyValue<K, V>);
            foreach (var linkedlist1 in item)
            {
                if (linkedlist != null)
                {
                    foreach (var ele in linkedlist)
                    {
                        if (ele.key.Equals(word1))
                        {
                            itemFound = true;
                            founditem = ele;
                        }
                    }
                }
            }
            if (itemFound)
            {
                linkedlist.Remove(founditem);
            }
        }
        int getArrayPossition(K key)
        {
            throw new NotImplementedException();
        }

        public LinkedList<keyValue<K, V>> GetLinkedList(int possition)
        {
            LinkedList<keyValue<K, V>> linkedlist = item[possition];
            if (linkedlist == null)
            {
                linkedlist = new LinkedList<keyValue<K, V>>();  //here adding linkedlist stored in array
                item[possition] = linkedlist;
            }
            return linkedlist;
        }

        public bool Exists(K key)
        {
            int possition = getArrayPossition(key);
            LinkedList<keyValue<K, V>> linkedlist = GetLinkedList(possition);
            foreach (keyValue<K, V> item in linkedlist)
            {
                if (item.key.Equals(key))
                {
                    return true;
                }
            }
            return false;
        }

        public void Display()
        {
            foreach (var linkedlist in item)
            {
                if (linkedlist != null)
                {
                    foreach (var element in linkedlist)
                    {
                        string res = element.ToString();
                        if (res != null)
                            Console.WriteLine(element.key + " = " + element.value);
                    }
                }
            }
        }
    }
}
