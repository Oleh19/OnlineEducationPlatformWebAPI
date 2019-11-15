using DbLayer;
using DbLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
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

        #region Public Methods

        public async Task<T> GetByIdAsync(int id)
        {
            return await context.Set<T>().FindAsync(id);
        }

        public async Task<T> GetFirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().FirstOrDefaultAsync(predicate);
        }

        public async Task Add(T entity)
        {
            // await Context.AddAsync(entity);
            await context.Set<T>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public Task Update(T entity)
        {
            // In case AsNoTracking is used
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChangesAsync();
        }

        public Task Remove(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await context.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await context.Set<T>().Where(predicate).ToListAsync();
        }

        public Task<int> CountAllAsync() => context.Set<T>().CountAsync();

        public Task<int> CountWhereAsync(Expression<Func<T, bool>> predicate)
            => context.Set<T>().CountAsync(predicate);

        #endregion
    }
}
