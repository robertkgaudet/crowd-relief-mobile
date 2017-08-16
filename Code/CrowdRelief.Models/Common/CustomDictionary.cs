using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrowdRelief.Models.Common
{
    public class CustomDictionary<K, V> : Dictionary<K, V>
    {
        public delegate void DictionaryChanged(object sender, DictChangedEventArgs<K, V> e);

        public event DictionaryChanged OnDictionaryChanged;

        public new void Add(K key, V value)
        {
            OnDictionaryChanged?.Invoke(this, new DictChangedEventArgs<K, V>() { Key = key, Value = value });

            base.Add(key, value);
        }
    }

    public class DictChangedEventArgs<K, V> : EventArgs
    {
        public K Key { get; set; }
        public V Value { get; set; }
    }
}
