using System.Threading.Tasks;
using MediaDatabase.Dashboard.Cache.Interfaces;

namespace MediaDatabase.Dashboard.Cache
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