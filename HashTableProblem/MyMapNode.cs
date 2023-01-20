using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableProblem
{
    public class MyMapNode<K, V>
    {
        LinkedList<KeyValue<K, V>> list = new LinkedList<KeyValue<K, V>>();
        public void Add (K key, V value)
        {
            KeyValue<K, V> obj = new KeyValue<K, V>() { key = key, value = value};
            list.AddLast(obj);
        }
        public void GetFreq()
        {
            int count = 0;
            if(list.Count == 0)
            {
                Console.WriteLine("HashTable is empty");
                return;
            }
            foreach(KeyValue<K, V> obj in list)
            {
               foreach(KeyValue<K, V> pair in list) 
               {
                    if (obj.value.Equals(pair.value))
                        count++;
               }
                Console.WriteLine("Count of "+ obj.value +" is " + count);
                count = 0;
            }
        }
    }
    public struct KeyValue<K, V>
    {
        public K key;
        public V value; 
    }
}
