using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Generics_advanced_c__01
{
    //Q20: Complete Exercise -Create a generic Cache < TKey, TValue>with Add, Get, Remove, Contains, and expiration support.

    public class CacheItem<TValue>
    {
        public TValue Value { get; set; }

        public DateTime ExpirationTime { get; set; }


        public CacheItem(
            TValue value,
            DateTime expirationTime)
        {
            Value = value;
            ExpirationTime = expirationTime;
        }
    }
    //da class by3ml store l value , expiration time .
}
