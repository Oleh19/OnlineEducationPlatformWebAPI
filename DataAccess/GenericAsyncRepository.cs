using DbLayer;
using DbLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess
{
    public abstract class GenericAsyncRepository<Entity> : IAsyncRepository<Entity> where Entity : BaseEntity
    {
        #region Fields

        protected EducationPlatformDbContext  context;

        #endregion

        public GenericAsyncRepository(EducationPlatformDbContext context)
        {
            this.context = context;
        }

        #region GetMethods
        public async Task<IEnumerable<Entity>> GetAllAsync()
        {
            return await context.Set<Entity>().ToListAsync();
        }

        public async Task<IEnumerable<Entity>> GetWhereAsync(Expression<Func<Entity, bool>> predicate)
        {
            return await context.Set<Entity>().Where(predicate).ToListAsync();
        }

        public async Task<Entity> GetByIdAsync(int id)
        {
            return await context.Set<Entity>().FindAsync(id);
        }

        public async Task<Entity> GetFirstOrDefaultAsync(Expression<Func<Entity, bool>> predicate)
        {
            return await context.Set<Entity>().FirstOrDefaultAsync(predicate);
        }
        #endregion

        #region CountMethods
        public async Task<int> CountAllAsync()
        {
            return await context.Set<Entity>().CountAsync();
        }

        public async Task<int> CountWhereAsync(Expression<Func<Entity, bool>> predicate)
        {
            return await context.Set<Entity>().CountAsync(predicate);
        }
        #endregion

        #region ModificationMethods
        public void Add(Entity entity)
        {
             context.Set<Entity>().Add(entity);
        }

        public void Update(Entity entity)
        {
            context.Set<Entity>().Update(entity);
        }

        public void Remove(Entity entity)
        {
            context.Set<Entity>().Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
        #endregion
    }
}
