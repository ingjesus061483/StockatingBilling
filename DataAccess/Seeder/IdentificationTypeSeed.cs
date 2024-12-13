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
    internal class IdentificationTypeSeed : IEntityTypeConfiguration<IdentificationType>
    {
        public void Configure(EntityTypeBuilder<IdentificationType> builder)
        {
           builder.HasData(
                           new IdentificationType { Id = 1, Name = "cedula de ciudadania", Description = "" },
                           new IdentificationType { Id = 2, Name = "nit", Description = "" }
                           );
        }
    }
}
