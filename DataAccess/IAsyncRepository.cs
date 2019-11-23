using DbLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IAsyncRepository<Entity> where Entity : BaseEntity
    {
        Task<IEnumerable<Entity>> GetAllAsync();
        Task<IEnumerable<Entity>> GetWhereAsync(Expression<Func<Entity, bool>> predicate);

        Task<Entity> GetByIdAsync(int id);
        Task<Entity> GetFirstOrDefaultAsync(Expression<Func<Entity, bool>> predicate);

        Task<int> CountAllAsync();
        Task<int> CountWhereAsync(Expression<Func<Entity, bool>> predicate);

        void Add(Entity entity);
        void Update(Entity entity);
        void Remove(Entity entity);
        Task SaveChangesAsync();

    }
}
