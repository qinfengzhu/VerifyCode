using System;
using System.Collections.Generic;

namespace VerifyCode.Core
{
    public class StaicMemoryCache : ICache
    {
        Dictionary<string, object> m_cache = new Dictionary<string, object>();
        public void Clear()
        {
            m_cache.Clear();
        }

        public object Get(string key)
        {
            if(m_cache.ContainsKey(key))
            {
                object value = null;
                m_cache.TryGetValue(key, out value);
                return value;
            }
            return null;
        }

        public T Get<T>(string key, Func<T> handler)
        {
            if (m_cache.ContainsKey(key))
            {
                object value = null;
                m_cache.TryGetValue(key, out value);
                if (value is T)
                {
                    return (T)value;
                }
                return default(T);
            }
            else
            {
                if(handler!=null)
                {
                    var value = handler();
                    m_cache.Add(key, value);
                    return value;
                }
                return default(T);
            }
        }

        public T Get<T>(string key, Func<T> handler, int expirationMinutes)
        {
            return Get(key, handler);
        }

        public T Get<T>(string key, Func<T> handler, DateTime absoluteExpiration)
        {
            return Get(key, handler);
        }

        public bool IsExistKey(string key)
        {
            if (m_cache.ContainsKey(key))
                return true;
            return false;
        }

        public object Remove(string key)
        {
            if(m_cache.ContainsKey(key))
            {
                var value = m_cache[key];               
                m_cache.Remove(key);
                return value;
            }
            return null;
        }

        public void Set(string key, object data)
        {
            if(m_cache.ContainsKey(key))
            {
                m_cache[key] = data;
            }
            else
            {
                m_cache.Add(key, data);
            }
        }

        public void Set(string key, object data, int expirationMinutes)
        {
            Set(key, data);
        }

        public void Set(string key, object data, DateTime absoluteExpiration)
        {
            Set(key, data);
        }
    }
}
