using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimeDatabase.Web.Cache.Interfaces
{
    public interface ICache<TEntity> where TEntity : class
    {
        Task Init();

        TEntity Get();

        Task PopulateData();

        Task<bool> WriteToJsonCache();

        Task<CacheModel<TEntity>> ReadFromJsonCache();
    }
}