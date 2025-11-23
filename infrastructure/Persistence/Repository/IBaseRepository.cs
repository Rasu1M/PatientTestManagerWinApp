using PatientTestManagerWinApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientTestManagerWinApp.infrastructure.Persistence.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        IQueryable<TEntity> AsQueryable();
        List<TEntity> GetAllAsync(Func<TEntity, bool> condition);
        Task<TEntity?> GetAsync(int id);
        Task AddAsync(TEntity entity);

        void Delete(TEntity entity);
        Task DeleteAsync(int id);

        void Update(TEntity entity);
    }
}
