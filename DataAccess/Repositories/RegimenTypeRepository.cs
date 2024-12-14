using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class RegimenTypeRepository : IRepository<RegimentypeDTO>
    {
        public StockatingDbContext Db { get ; set ; }

        public IQueryable<RegimentypeDTO> Values => Db.RegimenTypes.Select(x=>new RegimentypeDTO
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
        });
        public RegimenTypeRepository(StockatingDbContext db) 
        {
            Db = db;    
        }

        public void DeleteById(int id)
        {
            RegimenType regimenType=Db.RegimenTypes.FirstOrDefault(x=>x.Id==id);
            Db.RegimenTypes.Remove(regimenType);
            Db.SaveChanges();
        }

        public RegimentypeDTO GetById(int id) => Values.Where(x => x.Id == id).FirstOrDefault();
        
        public void Save(RegimentypeDTO entity)
        {
            RegimenType regimenType = new RegimenType
            {
                Name = entity.Name,
                Description = entity.Description,

            };
            Db.RegimenTypes.Add(regimenType);
            Db.SaveChanges();
        }

        public void Update(RegimentypeDTO entity, int id)
        {
            RegimenType regimenType = Db.RegimenTypes.FirstOrDefault(x => x.Id == id);
            regimenType.Name = entity.Name;
            regimenType.Description = entity.Description;
            Db.RegimenTypes.Update(regimenType);
            Db.SaveChanges();
        }
    }
}
