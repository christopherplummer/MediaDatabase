using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnimeDatabase.Web.Cache.Interfaces;

namespace AnimeDatabase.Web.Cache
{
    public abstract class Cache<TEntity> : ICache<TEntity> where TEntity : class
    {
        public abstract Task Init();

        public abstract TEntity Get();

        public abstract Task PopulateData();

        public abstract Task<bool> WriteToJsonCache();

        public abstract Task<CacheModel<TEntity>> ReadFromJsonCache();
    }
}