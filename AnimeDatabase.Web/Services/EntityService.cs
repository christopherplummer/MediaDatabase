using AnimeDatabase.Web.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimeDatabase.Web.Services
{
    public abstract class EntityService<TEntity> : IEntityService<TEntity> where TEntity : class
    {
        protected readonly IConfiguration _config;

        protected readonly IRestClient _restClient;

        protected EntityService(IRestClient restClient, IConfiguration config)
        {
            _config = config;
            _restClient = restClient;
        }

        public abstract Task<List<TEntity>> Get();

        //public abstract Task<TEntity> Get(Guid id);

        //public abstract Task<TEntity> Post(TEntity model);

        //public abstract Task<TEntity> Put(TEntity model);

        //public abstract Task<bool> Delete(Guid id);
    }
}
