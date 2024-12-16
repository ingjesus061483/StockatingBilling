using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class TaxRepository : IRepository<TaxDTO>
    {
        public StockatingDbContext Db { get; set ; }
        public TaxRepository(StockatingDbContext db) { 
            Db = db;
        }

        public IQueryable<TaxDTO> Values => Db.Taxes.Select(x => new TaxDTO
        {
            Id = x.Id,
            Name = x.Name,
            Value = x.Value,
            Description = x.Description,
        });

        public void DeleteById(int id)
        {
            Tax tax = Db.Taxes.FirstOrDefault(x => x.Id == id);
            Db.Taxes.Remove(tax);
        }

        public TaxDTO GetById(int id) => Values.FirstOrDefault(x => x.Id == id);
        

        public void Save(TaxDTO entity)
        {
            Tax tax = new Tax
            {                
                Name = entity.Name,
                Value = entity.Value,
                Description = entity.Description,
            };
            Db.Taxes.Add(tax);
            Db.SaveChanges();
        }

        public void Update(TaxDTO entity, int id)
        {
            Tax tax =Db.Taxes .FirstOrDefault(x => x.Id == id);
            tax.Name = entity.Name;
            tax.Value = entity.Value;
            tax.Description = entity.Description;
            Db .Taxes .Update(tax);
            Db.SaveChanges();
        }
    }
}
