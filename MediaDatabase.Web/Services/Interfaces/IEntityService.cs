using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediaDatabase.Web.Services.Interfaces
{
    public interface IEntityService<TEntity> where TEntity : class
    {
        Task<List<TEntity>> Get();

        //Task<TEntity> Get(Guid id);

        //Task<TEntity> Post(TEntity model);

        //Task<TEntity> Put(TEntity model);

        //Task<bool> Delete(Guid id);
    }
}