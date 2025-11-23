using Microsoft.EntityFrameworkCore;
using PatientTestManagerWinApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientTestManagerWinApp.infrastructure.Persistence.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly PatientTestManagerDBContext _dbContext;
        public BaseRepository(PatientTestManagerDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
        }

        public IQueryable<TEntity> AsQueryable()
        {
            return _dbContext.Set<TEntity>().AsQueryable();
        }

        public void Delete(TEntity entity)
        {
            if (entity is not null)
            {
                _dbContext.Remove(entity);
            }
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.ID == id);

            if (entity is not null)
            {
                _dbContext.Remove(entity);
            }
        }

        public List<TEntity> GetAllAsync(Func<TEntity, bool> condition)
        {
            return _dbContext.Set<TEntity>().Where(condition).ToList();
        }

        public async Task<TEntity?> GetAsync(int id)
        {
            return await _dbContext.Set<TEntity>().Where(e => e.ID == id).FirstOrDefaultAsync();
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
        }
    }
}
