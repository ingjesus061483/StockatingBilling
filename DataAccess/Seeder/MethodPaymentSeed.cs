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
   public class MethodPaymentSeed : IEntityTypeConfiguration<MethodPayment>
    {
        public void Configure(EntityTypeBuilder<MethodPayment> builder)
        {
            builder.HasData(new MethodPayment { Id = 1, Name = "Contado", Description = "" },
                new MethodPayment { Id = 2, Name = "Datafono", Description = "" },
                new MethodPayment { Id = 3, Name = "Tranferencia", Description = "" });
        }
    }
}
