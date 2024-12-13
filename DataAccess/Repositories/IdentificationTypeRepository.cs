using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class IdentificationTypeRepository : IRepository<IdentificationTypeDTO>
    {
        public StockatingDbContext Db { get; set; }

        public IQueryable<IdentificationTypeDTO> Values => Db.IdentificationTypes.Select(x => new IdentificationTypeDTO
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
        });
        public IdentificationTypeDTO GetById(int id) => Values.Where(x => x.Id == id).FirstOrDefault();

        public IdentificationTypeRepository(StockatingDbContext db)
        {
            Db = db;
        }

        public void DeleteById(int id)
        {
           IdentificationType identificationType  = Db.IdentificationTypes .Where(x => x.Id == id).FirstOrDefault();
            Db.IdentificationTypes.Remove(identificationType);
            Db.SaveChanges();
        }
        public void Save(IdentificationTypeDTO entity)
        {
            IdentificationType identificationType = new()
            {
                Name = entity.Name,
                Description = entity.Description,
            };
            Db.IdentificationTypes.Add(identificationType );
            Db.SaveChanges();
        }

        public void Update(IdentificationTypeDTO entity, int id)
        {
            IdentificationType identificationType = Db.IdentificationTypes.Where(x => x.Id == id).FirstOrDefault();
            identificationType .Name = entity.Name;
            identificationType .Description = entity.Description;
            Db.IdentificationTypes.Update(identificationType);
            Db.SaveChanges();
        }
    }
}
