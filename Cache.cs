using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generics_advanced_c__01
{
   // Q20: Complete Exercise -Create a generic Cache < TKey, TValue>with Add, Get, Remove, Contains, and expiration support.

    public class Cache <TKey, TValue>
    {
        private Dictionary<TKey, CacheItem<TValue>> items = new Dictionary<TKey, CacheItem<TValue>>();
        public void Add( TKey key, TValue value, int expirationSeconds)
        {
            DateTime expirationTime = DateTime.Now.AddSeconds(expirationSeconds);

            CacheItem<TValue> newItem = new CacheItem<TValue>( value,expirationTime );

            items[key] = newItem;
        }
        //kda el add method bt5zn l value w expiration time fe cache item object w bt7to fe dictionary.
        public TValue Get(TKey key)
        {
            if (!items.ContainsKey(key))
            {
                return default(TValue);
            }

            CacheItem<TValue> item = items[key];

            if (DateTime.Now >= item.ExpirationTime)
            {
                items.Remove(key);

                return default(TValue);
            }

            return item.Value;
        }
        //kda el get method bt check lw l key mawgod fe dictionary w lw mawgod bt check lw l expiration time 3la 7sb el current time w lw expired bt remove l key mn dictionary w return default value.

        public bool Contains(TKey key)
        {
            if (!items.ContainsKey(key))
            {
                return false;
            }

            CacheItem<TValue> item =items[key];

            if (DateTime.Now >= item.ExpirationTime)
            {
                items.Remove(key);

                return false;
            }

            return true;
        }
        //kda el contains method bt check lw l key mawgod fe dictionary w lw mawgod bt check lw l expiration time 3la 7sb el current time w lw expired bt remove l key mn dictionary w return false.
        //y3ni d bt check lw l key mawgod w lw mawgod expired aw la2 w return true or false.

        public bool Remove(TKey key)
        {
            return items.Remove(key);
        }
        //remove method bt remove l key mn dictionary
    }
}
