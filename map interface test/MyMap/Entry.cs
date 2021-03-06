﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMap
{
    public class Entry<K, V> : IEntry<K, V>
    {
        public Entry()
        {

        }

        public Entry(K key, V value)
        {
            Key = key;
            Value = value;
        }

        public K Key { get; set; }
        public V Value { get; set; }

        public override string ToString()
        {
            return Key.ToString() + ' ' + Value.ToString();
        }
    }
}
