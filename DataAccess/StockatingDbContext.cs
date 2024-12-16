using DataAccess.Seeder;
using Factory;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DataAccess
{
    public class StockatingDbContext:DbContext
    {
        string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Stockating"].ConnectionString;
            }
        }

        public DbSet<RegimenType> RegimenTypes { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet <Client> Clients { get; set; }
        public DbSet <IdentificationType> IdentificationTypes { get; set; }
        public DbSet <Employee> Employees { get; set; }
        public DbSet <User > Users { get; set; }    
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Picture> Pictures {  get; set; }
        public DbSet<PictureProduct> PictureProducts { get; set; }
        public DbSet<UnitMeasurement> UnitMeasurement { get; set; } 
        public DbSet<Warehouse> Warehouse { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet <Tax> Taxes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new IdentificationTypeSeed());
            modelBuilder .ApplyConfiguration(new RegimenTypeSeed());
            modelBuilder.ApplyConfiguration (new CompanySeed());
            modelBuilder .ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new EmployeeSedd());
            modelBuilder.ApplyConfiguration(new UnitMeasurementSeed());

        }
    }
}
