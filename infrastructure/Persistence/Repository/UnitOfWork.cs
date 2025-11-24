
using PatientTestManagerWinApp.ApplicationLayer.Models;

namespace PatientTestManagerWinApp.infrastructure.Persistence.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PatientTestManagerDBContext _dbContext;
        public UnitOfWork(PatientTestManagerDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void ClearTracker()
        {
            _dbContext.ChangeTracker.Clear();
        }

        public int SaveChanges()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
