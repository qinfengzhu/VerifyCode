using System;

namespace VerifyCode.Core
{
    public interface ICache
    {
        object Get(string key);
        object Remove(string key);
        void Clear();
        void Set(string key, object data);
        void Set(string key, object data, int expirationMinutes);
        void Set(string key, object data, DateTime absoluteExpiration);
        T Get<T>(string key, Func<T> handler);
        T Get<T>(string key, Func<T> handler, int expirationMinutes);
        T Get<T>(string key, Func<T> handler, DateTime absoluteExpiration);
        bool IsExistKey(string key);
    }
}
