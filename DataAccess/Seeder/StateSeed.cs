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
    internal class StateSeed : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.HasData(
                new State {Id =1,Name="En proceso",Description=""  },
                 new State { Id = 2, Name = "Entregado", Description = "" },
                new State { Id = 3, Name = "Pagado", Description = "" },

                new State { Id = 4, Name = "En mora" ,Description=""});
        }
    }
}
