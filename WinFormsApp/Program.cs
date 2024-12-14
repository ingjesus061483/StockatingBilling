using DataAccess;
using DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ServiceCollection services = new ServiceCollection();
            Configservice(services);
            //using var servicesprovider = services.BuildServiceProvider();
            var servicesprovider = services.BuildServiceProvider();
            var frmPrincipal = servicesprovider.GetRequiredService<FrmMain>();
            Application.Run(frmPrincipal);
        }
        static void Configservice(ServiceCollection services)
        {
            services .AddScoped <IdentificationTypeRepository> ();
            services .AddScoped<ClientRepository> ();
            services.AddScoped<StockatingDbContext>();
            services.AddScoped<ProductRepository>();
            services.AddScoped<CategoryRepository>();
            services.AddScoped<UnitMeasurementRepository>();
            services.AddScoped<PictureRepository>();   
            services.AddScoped<WarehouseRepository>();
            services.AddScoped<FrmMain>();
            services.AddScoped<StockRepository>();
            services.AddScoped<RoleRepository>();
            services.AddScoped<EmployeeRepository>();
            services.AddScoped<UserRepository>();
            services.AddScoped<CompanyRepository>();
            services.AddScoped<RegimenTypeRepository>();
            services.AddScoped<ProviderRepository>();

        }
    }
}