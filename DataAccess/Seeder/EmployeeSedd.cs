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
    internal class EmployeeSedd : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    Identification = "11111",
                    Name = "admin",
                    LastName = "admin",
                    Address = "B/quilla",
                    Phone = "55555",
                    IdentificationTypeId = 1,
                    UserId = 1
                });
        }
    }
}
