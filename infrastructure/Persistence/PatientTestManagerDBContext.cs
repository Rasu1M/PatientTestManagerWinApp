using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PatientTestManagerWinApp.Domain.Entities;

namespace PatientTestManagerWinApp.infrastructure.Persistence
{
    public class PatientTestManagerDBContext : DbContext
    {
        public PatientTestManagerDBContext(DbContextOptions<PatientTestManagerDBContext> options) : base(options) { }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class PatientTestManagerDBContextFactory :
    IDesignTimeDbContextFactory<PatientTestManagerDBContext>
    {
        public PatientTestManagerDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PatientTestManagerDBContext>();

            var dbPath = Path.Combine(AppContext.BaseDirectory, "Data Source=PatientTestManager.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");

            return new PatientTestManagerDBContext(optionsBuilder.Options);
        }
    }
}
