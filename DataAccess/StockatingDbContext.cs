using DataAccess.Seeder;
using Factory;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class StockatingDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
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
            optionsBuilder.UseMySQL("server=localhost;database=Inventario;user=root;password=");            
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
            /*modelBuilder.Entity<Role>().HasData(
                new Role { Id =1, Name = "Administrador" ,Description=""}
                );
            modelBuilder.Entity<IdentificationType>().HasData(
                new IdentificationType {Id=1, Name = "cedula de ciudadania", Description = "" },
                new IdentificationType {Id=2, Name = "nit", Description = "" }
                );
            modelBuilder.Entity<RegimenType>().HasData(
                new RegimenType {Id =1,  Name="Simplificado",Description=""},
                new RegimenType {Id = 2, Name="Comun",Description=""}
                );
            modelBuilder.Entity<Company>().HasData(
                new Company
                {
                    Id = 1,
                    Nit = "11111 - 1",
                    Name = "Empresa de prueba",
                    TradeCamera = "0001",
                    Direction = "b / quilla",
                    Phone = "5444555",
                    Email = "alguien@ejempo.com",
                    Contact = "pepito perez",
                    slogan = "",
                    RegimenTypeId = 1
                });

            modelBuilder.Entity<User>().HasData(
                new User {  Email = "example1@mail.com", Id = 1, Name = "admin",Password="admin1234.",RoleId=1,Companyid=1 }                
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee 
                { 
                    Id=1,
                    Identification = "11111",
                    Name = "admin", 
                    LastName = "admin",
                    Address = "B/quilla",
                    Phone = "55555",
                    IdentificationTypeId = 1,
                    UserId = 1
                });*/
        }
    }
}
