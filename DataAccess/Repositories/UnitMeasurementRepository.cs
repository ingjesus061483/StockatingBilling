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
    public class UnitMeasurementRepository : IRepository<UnitMeasurementDTO>
    {
        public StockatingDbContext Db { get ; set ; }

        public UnitMeasurementRepository(StockatingDbContext db)
        {
            Db = db;
        }

        public IQueryable<UnitMeasurementDTO> Values => Db .UnitMeasurement. Select(x=>new UnitMeasurementDTO
        {
            Id = x.Id,
            Name = x.Name,
            Description = x.Description,
        });

        public void DeleteById(int id)
        {
            UnitMeasurement unitMeasurement = Db .UnitMeasurement.Where(x =>x.Id == id).FirstOrDefault();
           Db.UnitMeasurement.Remove(unitMeasurement);
            Db.SaveChanges();
        }

        public UnitMeasurementDTO GetById(int id)=>Values.Where(x=> x.Id == id).FirstOrDefault();
        

        public void Save(UnitMeasurementDTO entity)
        {
            UnitMeasurement unitMeasurement = new UnitMeasurement {                 
                Name = entity.Name,
                Description = entity.Description,
            };
            Db.UnitMeasurement.Add(unitMeasurement);
            Db.SaveChanges();
        }

        public void Update(UnitMeasurementDTO entity, int id)
        {
            UnitMeasurement unitMeasurement=Db.UnitMeasurement.Where(x=>x.Id == id).FirstOrDefault();
            unitMeasurement.Name = entity.Name;
            unitMeasurement.Description = entity.Description;
           Db.UnitMeasurement.Update(unitMeasurement);
            Db.SaveChanges();
        }
    }
}
