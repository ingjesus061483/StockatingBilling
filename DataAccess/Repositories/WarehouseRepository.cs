using DTO;
using Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccess.Repositories
{
    public class WarehouseRepository : IRepository<WarehouseDTO>
    {
        public StockatingDbContext Db { get; set; }

        public IQueryable<WarehouseDTO> Values => Db.Warehouse.Select(x=> new WarehouseDTO { 
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            Descripcion = x.Descripcion,
            limitado = x.limitado,
            StockMaximo=x.StockMaximo,
            StockMinimo=x.StockMinimo,
        });
        public WarehouseRepository(StockatingDbContext db)
        {
            Db = db;
        }

        public void DeleteById(int id)
        {
            var warehouse=Db.Warehouse.Where(x=>x.Id==id).FirstOrDefault();
            Db .Warehouse.Remove(warehouse);
            Db.SaveChanges();            
        }

        public WarehouseDTO GetById(int id)=> Values.Where(x => x.Id == id).FirstOrDefault();
        

        public void Save(WarehouseDTO entity)
        {
            Warehouse warehouse = new Warehouse
            {
                Code = entity.Code,
                Name = entity.Name,
                Descripcion = entity.Descripcion,
                limitado = entity.limitado,
                StockMaximo = entity.StockMaximo,
                StockMinimo = entity.StockMinimo,
            };
            Db .Warehouse.Add(warehouse);
            Db.SaveChanges();
        }

        public void Update(WarehouseDTO entity, int id)
        {
            var warehouse=Db .Warehouse.Where(x=>x.Id==id).FirstOrDefault();
            warehouse.Code = entity.Code;
            warehouse.Name = entity.Name;
            warehouse.Descripcion = entity.Descripcion;
            warehouse.limitado = entity.limitado;
            warehouse.StockMaximo = entity.StockMaximo;
            warehouse.StockMinimo = entity.StockMinimo;
            Db.Warehouse.Update(warehouse);
            Db.SaveChanges();
            
        }
    }
}
