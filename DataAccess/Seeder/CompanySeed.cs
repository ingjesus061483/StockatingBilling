using Factory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeder
{
    internal class CompanySeed : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
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
        }
    }
}
