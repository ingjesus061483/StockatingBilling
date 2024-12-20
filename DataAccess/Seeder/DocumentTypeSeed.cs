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
    class DocumentTypeSeed : IEntityTypeConfiguration<DocumentType>
    {
        public void Configure(EntityTypeBuilder<DocumentType> builder)
        {
            builder.HasData(new DocumentType { Id = 1, Name = "Factura", Description = "" },
                new DocumentType { Id = 2, Name = "Compra", Description = "" },
                new DocumentType { Id = 3, Name = "Ticket", Description = "" });
        }
    }
}
