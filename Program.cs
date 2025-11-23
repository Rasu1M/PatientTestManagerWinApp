using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PatientTestManagerWinApp.ApplicationLayer.Services;
using PatientTestManagerWinApp.ApplicationLayer.Services.Abstract;
using PatientTestManagerWinApp.infrastructure.Persistence;
using PatientTestManagerWinApp.infrastructure.Persistence.Repository;

namespace PatientTestManagerWinApp
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            using var serviceProvider = services.BuildServiceProvider();

            Application.SetCompatibleTextRenderingDefault(false);

            var mainForm = serviceProvider.GetRequiredService<MainPage>();

            Application.EnableVisualStyles();
            Application.Run(mainForm);
        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PatientTestManagerDBContext>(options =>
            {
                var dbPath = Path.Combine(AppContext.BaseDirectory, "Data Source=PatientTestManager.db");
                options.UseSqlite($"Data Source={dbPath}");
            });

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ITestsService, TestsService>();
            services.AddScoped<IPatientsService, PatientsService>();

            services.AddTransient<MainPage>();
        }
    }
}