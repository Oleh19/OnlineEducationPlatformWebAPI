using BusinessLogic.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public interface IAsyncService<EntityDTO> where EntityDTO : BaseEntityDTO
    {
        Task<IEnumerable<EntityDTO>> GetAllAsync();
        Task<IEnumerable<EntityDTO>> GetWhereAsync(Expression<Func<EntityDTO, bool>> predicate);

        Task<EntityDTO> GetByIdAsync(int id);
        Task<EntityDTO> GetFirstOrDefaultAsync(Expression<Func<EntityDTO, bool>> predicate);

        Task<int> CountAllAsync();
        Task<int> CountWhereAsync(Expression<Func<EntityDTO, bool>> predicate);

        Task Add(EntityDTO entityDTO);
        Task Update(EntityDTO entityDTO);
        Task Remove(int id);
    }
}
