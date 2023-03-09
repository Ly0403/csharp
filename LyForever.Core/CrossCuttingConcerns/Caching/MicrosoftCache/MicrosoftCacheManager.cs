using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Caching;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LyForever.Core.CrossCuttingConcerns.Caching.MicrosoftCache
{
    public class MicrosoftCacheManager : ICacheManager
    {
        //protected ObjectCache ObjectCache 
        //{
        //    get
        //    {
        //        return MemoryCache.Default;
        //    }   
        //}
        protected ObjectCache Cache => MemoryCache.Default;
        public void Add(string key, object data, int cacheTime)
        {
            if (data==null)
            {
                return;
            }
            var cachePolicy = new CacheItemPolicy() { AbsoluteExpiration=DateTime.Now+TimeSpan.FromMinutes(cacheTime)};
            Cache.Add(key, data, cachePolicy);
        }

        public void Clear()
        {
            foreach (var item in Cache) { Remove(item.Key); }
        }

        public T Get<T>(string key)
        {
            return (T)Cache.Get(key);
        }

        public bool isAdd(string key)
        {
            return Cache.Contains(key);
        }

        public void Remove(string key)
        {
            Cache.Remove(key);
        }

        public void RemoveByPattern(string pattern)
        {
            var regex = new Regex(pattern,RegexOptions.Singleline|RegexOptions.IgnoreCase|RegexOptions.Compiled);
            var cachesToMove = Cache.Where(k=>regex.IsMatch(k.Key)).Select(k=>k.Key).ToList();

            foreach (var item in cachesToMove)
            {
                Remove(item);
            }
        }
    }
}
