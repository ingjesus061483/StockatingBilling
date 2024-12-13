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
   public class ClientRepository : IRepository<ClientDTO>
    {
        public StockatingDbContext Db { get ; set ; }
        public ClientRepository(StockatingDbContext db ) 
        {
            Db = db;    
        }
        public IQueryable<ClientDTO> Values =>Db .Clients.Include(c=>c.IdentificationType).Select(x=>new ClientDTO { 
            Id=x.Id,
            IdentificationType=x.IdentificationType,
            IdentificationTypeId=x.IdentificationTypeId,
            Identification=x.Identification,
            Name=x.Name,
            LastName=x.LastName,
            Address=x.Address,
            Phone=x.Phone,
            Email=x.Email,            
        });

        public void DeleteById(int id)
        {
            Client Client  = Db.Clients.Where(x=>x.Id == id).FirstOrDefault();
            Db.Clients.Remove(Client);
            Db.SaveChanges();

          
        }

        public ClientDTO GetById(int id)=>Values.Where(x=>x.Id==id).FirstOrDefault();
        

        public void Save(ClientDTO entity)
        {
            Client client = new()
            {
                IdentificationTypeId = entity.IdentificationTypeId,
                Identification = entity.Identification,
                Name = entity.Name,
                LastName = entity.LastName,
                Address = entity.Address,
                Phone = entity.Phone,
                Email = entity.Email,
            };
            Db.Clients.Add(client);
            Db.SaveChanges();
        }

        public void Update(ClientDTO entity, int id)
        {
            Client client=Db.Clients .Where (x=>x.Id == id).FirstOrDefault();
            client.IdentificationTypeId = entity.IdentificationTypeId;
            client.Identification = entity.Identification;
            client.Name = entity.Name;
            client.LastName = entity.LastName;
            client.Address = entity.Address;
            client.Phone = entity.Phone;
            client.Email = entity.Email;
            Db .Clients.Update(client);
            Db.SaveChanges ();
        }
    }
}
