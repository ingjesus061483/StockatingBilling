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
public  class UserRepository : IRepository<UserDTO>
    {
        public StockatingDbContext Db { get ; set ; }

        public IQueryable<UserDTO> Values => Db.Users.Include(e=>e.Role).Include(e=>e.Employees).Include (e=>e.Company ).Select(x=>new UserDTO { 
        Id = x.Id,
        Name = x.Name,
         Employees = x.Employees,
         RoleId = x.RoleId,
         Password = x.Password,
         Role=x.Role,
         Company = x.Company,
         CompanyId = x.CompanyId,
         Email = x.Email,
        });
        public UserRepository( StockatingDbContext db) { 
            Db = db;    
        
        }
        public void DeleteById(int id)
        {
           User user= Db.Users.Where(x => x.Id == id).FirstOrDefault();
            Db.Users.Remove(user);
            Db.SaveChanges();
        }

        public UserDTO GetById(int id) => Values.Where(x => x.Id == id).FirstOrDefault();
       

        public void Save(UserDTO entity)
        {
            User user=new User 
            {
                Name = entity.Name,
                Email=entity.Email,
                RoleId = entity.RoleId,
                    Password = entity.Password, 
                    CompanyId=entity.CompanyId,
            };
            Db.Users.Add(user);            
            Db.SaveChanges();
            entity.Id =user .Id ;

        }

        public void Update(UserDTO entity, int id)
        {
            User user= Db.Users.Where(x => x.Id == id).FirstOrDefault();
            user.Name = entity.Name;
            user.Email = entity.Email;
            user.RoleId = entity.RoleId;
            user.Password = entity.Password;
            user.CompanyId = entity.CompanyId;  
            Db.Users .Update(user);
            Db.SaveChanges();


        }
    }
}
