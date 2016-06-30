using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericApp
{
    public class MultiDictionary<K, V> : IMultiDictionary<K, V>, IEnumerable<KeyValuePair<K, V>>
    {
        private Dictionary<K, LinkedList<V>> multiDictionary = new Dictionary<K, LinkedList<V>>();
        

        public int Count
        {
            get
            {
                int count = 0;
                foreach(LinkedList<V> listValues in multiDictionary.Values){
                    count += listValues.Count;
                }
                return count;
            }
        }

        public ICollection<K> Keys
        {
            get
            {
                return multiDictionary.Keys;
            }
        }

        public ICollection<V> Values
        {
            get
            {
                List<V> listValues = new List<V>();
                foreach(LinkedList<V> l in multiDictionary.Values)
                {
                    listValues.AddRange(l.ToList());
                }
                return listValues;
            }
        }

        public void Add(K key, V value)
        {
            if (!multiDictionary.ContainsKey(key))
            {
                multiDictionary.Add(key, new LinkedList<V>());
            }
            multiDictionary[key].AddLast(value);           
        }

        public void Clear()
        {
            multiDictionary.Clear();
        }

        public bool Contains(K key, V value)
        {

            LinkedList<V> list;
            if (!multiDictionary.TryGetValue(key, out list))
            {
                return false;
            }
            return list.Contains(value);

            
        }

        public bool ContainsKey(K key)
        {
            return multiDictionary.ContainsKey(key);
        }

        public IEnumerator<KeyValuePair<K, V>> GetEnumerator()
        {
            LinkedList<KeyValuePair<K, V>> listEnumerator = new LinkedList<KeyValuePair<K, V>>();

            foreach (KeyValuePair<K, LinkedList<V>> listValues in multiDictionary)
            {
                foreach (V item in listValues.Value)
                {
                    listEnumerator.AddLast(new KeyValuePair<K,V>(listValues.Key,item));
                }
            }
            return listEnumerator.GetEnumerator();               

        }

        public bool Remove(K key)
        {
          return multiDictionary.Remove(key);

        }

        public bool Remove(K key, V value)
        {
            LinkedList<V> list = new LinkedList<V>();
            if (!multiDictionary.TryGetValue(key, out list))
            {
                return false;
            }
            bool flag = list.Remove(value);
            while (flag && list.Remove(value))
            {                
            }
            return flag;
        }
        

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
