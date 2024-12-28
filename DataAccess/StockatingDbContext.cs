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
        public DbSet<State> States { get; set; }  
        public DbSet <Tax> Taxes { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<BillHeader> BillHeaders { get; set; }
        public DbSet <BillDetail> BillDetail { get; set; }
        public DbSet<Payment > Payments { get; set; }
        public DbSet<DetailPay> DetailPays { get; set; }
        public DbSet <MethodPayment> MethodPays { get; set; }
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
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(ConnectionString );
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DocumentTypeSeed());
            modelBuilder .ApplyConfiguration(new MethodPaymentSeed());
            modelBuilder.ApplyConfiguration(new RoleSeed());
            modelBuilder.ApplyConfiguration(new IdentificationTypeSeed());
            modelBuilder .ApplyConfiguration(new RegimenTypeSeed());
            modelBuilder.ApplyConfiguration (new CompanySeed());
            modelBuilder .ApplyConfiguration(new UserSeed());
            modelBuilder.ApplyConfiguration(new EmployeeSedd());
            modelBuilder.ApplyConfiguration(new UnitMeasurementSeed());
            modelBuilder.ApplyConfiguration(new StateSeed());
        }
    }
}
