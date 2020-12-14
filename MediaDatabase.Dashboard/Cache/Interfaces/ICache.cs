﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediaDatabase.Dashboard.Cache.Interfaces
{
    public interface ICache<TEntity> where TEntity : class
    {
        Task Init();

        List<TEntity> Get();

        Task PopulateData();

        Task<bool> WriteToJsonCache();

        Task<CacheModel<TEntity>> ReadFromJsonCache();
    }
}