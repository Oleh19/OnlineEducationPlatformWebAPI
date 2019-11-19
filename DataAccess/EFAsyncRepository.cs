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
    public abstract class EFAsyncRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        #region Fields

        protected EducationPlatformDbContext  context;

        #endregion

        public EFAsyncRepository(EducationPlatformDbContext context)
        {
            this.context = context;
        }

        #region GetMethods
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().FirstOrDefaultAsync(predicate);
        }
        #endregion

        #region CountMethods
        public async Task<int> CountAllAsync()
        {
            return await context.Set<T>().CountAsync();
        }

        public async Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().CountAsync(predicate);
        }
        #endregion

        #region ModificationMethods
        public void Add(T entity)
        {
             context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            context.Set<T>().Update(entity);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
        #endregion
    }
}
