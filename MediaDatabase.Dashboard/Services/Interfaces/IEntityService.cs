using System.Collections.Generic;
using System.Threading.Tasks;

namespace MediaDatabase.Dashboard.Services.Interfaces
{
    public interface IEntityService<TEntity> where TEntity : class
    {
        Task<List<TEntity>> Get();

        Task<TEntity> Get(int id);

        Task<TEntity> Post(TEntity model);

        //Task<TEntity> Put(TEntity model);

        //Task<bool> Delete(Guid id);
    }
}