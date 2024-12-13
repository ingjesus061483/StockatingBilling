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
    internal class RegimenTypeSeed : IEntityTypeConfiguration<RegimenType>
    {
        public void Configure(EntityTypeBuilder<RegimenType> builder)
        {
            builder.HasData(
                new RegimenType { Id = 1, Name = "Simplificado", Description = "" },
                new RegimenType { Id = 2, Name = "Comun", Description = "" }
                );
        }
    }
}
