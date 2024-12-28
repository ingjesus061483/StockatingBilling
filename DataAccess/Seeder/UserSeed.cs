using DataAccess.Repositories;
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
    internal class UserSeed : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                    new User { Email = "example1@mail.com", Id = 1, Name = "admin", Password =Utilities<string>.Encriptar ( "admin1234."), RoleId = 1, Companyid = 1 }
                     );
        }
    }
}
