using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RoleRepository : IRepository<RoleDTO>
    {
        public StockatingDbContext Db { get; set ; }
        public RoleRepository(StockatingDbContext stockatingDbContext  ) 
        {
            Db = stockatingDbContext;
        }

        public IQueryable<RoleDTO> Values => Db.Roles.Select(x => new RoleDTO
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
        });

        public void DeleteById(int id)
        {
            Role role = Db.Roles.FirstOrDefault(x => x.Id == id);
            Db.Roles.Remove(role);
            Db.SaveChanges();
        }

        public RoleDTO GetById(int id)=>Values .Where(x=>x.Id==id).FirstOrDefault();
        
        
        

        public void Save(RoleDTO entity)
        {
            Role role = new Role
            {
            
                Name = entity.Name,
                Description = entity.Description,
            };
            Db.Roles.Add(role);
            Db.SaveChanges();
        }

        public void Update(RoleDTO entity, int id)
        {
            Role role = Db.Roles.FirstOrDefault(    x=> x.Id == id);
            role.Name = entity.Name;
            role.Description = entity.Description;  
            Db.Roles.Update(role);
            Db.SaveChanges();

            
        }
    }
}
