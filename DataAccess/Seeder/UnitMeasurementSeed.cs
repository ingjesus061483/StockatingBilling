using Factory;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Seeder
{
    internal class UnitMeasurementSeed : IEntityTypeConfiguration<UnitMeasurement>
    {
        public void Configure(EntityTypeBuilder<UnitMeasurement> builder)
        {
            builder.HasData(new UnitMeasurement { Id = 1, Name = "Gramo", Description = "" }, new UnitMeasurement { Id = 2, Name = "Litro", Description = "" }, new UnitMeasurement { Id = 3, Name = "Unidad", Description = "" });
        }
    }
}
