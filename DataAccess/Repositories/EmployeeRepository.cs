using DTO;
using Factory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class EmployeeRepository : IRepository<EmployeeDTO>
    {
        public StockatingDbContext Db { get; set; }
        public EmployeeRepository(StockatingDbContext db)
        {
            Db = db;
        }


        public IQueryable<EmployeeDTO> Values => Db.Employees.Include(e=>e.User).Include (e=>e.IdentificationType).Include(e=>e.User.Role).Include (e=>e.User.Company).
            Select(x=> new EmployeeDTO {
                Id = x.Id,
                IdentificationType = x.IdentificationType,
                IdentificationTypeId = x.IdentificationTypeId,
                Identification = x.Identification,
                Name = x.Name,
                LastName = x.LastName,
                Address = x.Address,
                Phone = x.Phone,
                User= x.User,
                UserId = x.UserId,
               
            });

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO GetById(int id)=>Values.Where(x=>x.Id== id).FirstOrDefault();    


        public void Save(EmployeeDTO entity)
        {
            Employee employee = new Employee { 
                Identification=entity.Identification,
                Name=entity.Name,
                IdentificationTypeId=entity.IdentificationTypeId,
                Address=entity.Address,
                Phone=entity.Phone,
                UserId=entity.UserId,
                LastName=entity.LastName,
            };
            Db.Employees.Add(employee); 
            Db.SaveChanges();

        }

        public void Update(EmployeeDTO entity, int id)
        {
            Employee employee = Db.Employees.Where( x => x.Id == id).FirstOrDefault();
            employee.Name = entity.Name;
            employee.Identification = entity.Identification;
            employee .LastName = entity.LastName;
            employee.IdentificationTypeId = entity.IdentificationTypeId;
            employee.Address = entity.Address;
            employee.Phone = entity.Phone;
            employee.UserId = entity.UserId;
            Db.Employees .Update(employee);
            Db.SaveChanges ();
        }
    }
}
