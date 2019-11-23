using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using BusinessLogic.EntitiesDTO;
using DataAccess;
using DbLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class GenericAsyncService<Entity, EntityDTO> : IAsyncService<EntityDTO> where Entity : BaseEntity where EntityDTO : BaseEntityDTO
    {
        #region Fields

        protected IAsyncRepository<Entity> repository;
        protected readonly IMapper mapper;

        #endregion

        public GenericAsyncService(IAsyncRepository<Entity> repository)
        {
            this.repository = repository;
            this.mapper = InitMapper();
        }
        protected virtual IMapper InitMapper()
        {
            return new MapperConfiguration(cfg =>
            {
                cfg.AddExpressionMapping();
                cfg.CreateMap<Entity, EntityDTO>();
                cfg.CreateMap<EntityDTO, Entity>();

            }).CreateMapper();
        }

        #region PublicMethods
        public async Task<IEnumerable<EntityDTO>> GetAllAsync()
        {
            var data = await repository.GetAllAsync();
            return mapper.Map<IEnumerable<EntityDTO>>(data);
        }
        public async Task<IEnumerable<EntityDTO>> GetWhereAsync(Expression<Func<EntityDTO, bool>> predicateDTO)
        {
            var predicate = mapper.Map<Expression<Func<Entity, bool>>>(predicateDTO);
            var data = await repository.GetWhereAsync(predicate);
            return mapper.Map<IEnumerable<EntityDTO>>(data);
        }

        public async Task<EntityDTO> GetByIdAsync(int id)
        {
            var data = await repository.GetByIdAsync(id);
            return mapper.Map<EntityDTO>(data);
        }
        public async Task<EntityDTO> GetFirstOrDefaultAsync(Expression<Func<EntityDTO, bool>> predicateDTO)
        {
            var predicate = mapper.Map<Expression<Func<Entity, bool>>>(predicateDTO);
            var data = await repository.GetFirstOrDefaultAsync(predicate);
            return mapper.Map<EntityDTO>(data);
        }

        public async Task<int> CountAllAsync()
        {
            var data = await repository.CountAllAsync();
            return data;
        }
        public async Task<int> CountWhereAsync(Expression<Func<EntityDTO, bool>> predicateDTO)
        {
            var predicate = mapper.Map<Expression<Func<Entity, bool>>>(predicateDTO);
            var data = await repository.CountWhereAsync(predicate);
            return data;
        }

        public async Task Add(EntityDTO entityDTO)
        {
            var entity = mapper.Map<Entity>(entityDTO);
            repository.Add(entity);
            await repository.SaveChangesAsync();
        }
        public async Task Update(EntityDTO entityDTO)
        {
            var entity = mapper.Map<Entity>(entityDTO);
            repository.Update(entity);
            await repository.SaveChangesAsync();
        }
        public async Task Remove(int id)
        {
            var entity = await repository.GetByIdAsync(id);
            repository.Remove(entity);
            await repository.SaveChangesAsync();
        }

        #endregion
    }
}
