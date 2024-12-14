using DTO;
using Factory;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace DataAccess.Repositories
{
    public class ProviderRepository : IRepository<ProviderDTO>
    {
        public StockatingDbContext Db { get; set ; }
       public ProviderRepository(StockatingDbContext db)
        {
                Db = db;
        }
        public IQueryable<ProviderDTO> Values => Db.Providers .Include(x=>x.IdentificationType). Select(x=>new ProviderDTO { 
            IdentificationType = x.IdentificationType,
            Id = x.Id,
            Name = x.Name,
            Identification=x.Identification,
            LastName = x.LastName,
            Address = x.Address,
            Email = x.Email,
            Phone = x.Phone,
            IdentificationTypeId = x.IdentificationTypeId,
        });

        public void DeleteById(int id)
        {
            Provider provider =Db.Providers.Where(x=>x.Id == id).FirstOrDefault();
            Db.Providers.Remove(provider);
            Db.SaveChanges();
        }

        public ProviderDTO GetById(int id) => Values.Where(x => x.Id == id).FirstOrDefault();
        

        public void Save(ProviderDTO entity)
        {
            Provider provider = new Provider
            {
                Id = entity.Id,
                Name = entity.Name,
                Identification = entity.Identification,
                LastName = entity.LastName,
                Address = entity.Address,
                Email = entity.Email,
                Phone = entity.Phone,
                IdentificationTypeId = entity.IdentificationTypeId,
            };
            Db.Providers.Add(provider);
            Db.SaveChanges();
        }

        public void Update(ProviderDTO entity, int id)
        {
           Provider provider=Db.Providers.FirstOrDefault(x=>x.Id == id);
            provider.Id = entity.Id;
            provider.Name = entity.Name;
            provider.Identification = entity.Identification;
            provider.LastName = entity.LastName;
            provider.Address = entity.Address;
            provider.Email = entity.Email;
            provider.Phone = entity.Phone;
            provider.IdentificationTypeId = entity.IdentificationTypeId;
            Db.Providers.Update(provider);
            Db.SaveChanges();
        }
    }
}
