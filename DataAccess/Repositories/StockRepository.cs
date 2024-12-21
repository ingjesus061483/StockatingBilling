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
    public class StockRepository : IRepository<StockDTO>
    {
        public StockatingDbContext Db { get; set; }

        public IQueryable<StockDTO> Values => Db.Stocks.Include(s => s.Product).Include(s=>s.Warehouse) .Select(x=>new StockDTO
        {
            Date = x.Date,
            Entrance = x.Entrance,  
            Amount = x.Amount,  
            Id = x.Id,
            Product = x.Product,
            ProductId = x.ProductId,
            WarehouseId = x.WarehouseId,
            Warehouse=x.Warehouse,
        }) ;
        public StockRepository(StockatingDbContext db)
        {
            Db = db ;

        }

        public void DeleteById(int id)
        {
            Stock stock = Db.Stocks.FirstOrDefault(x => x.Id == id);
            Db .Stocks.Remove(stock);
            Db.SaveChanges();
        }

        public StockDTO GetById(int id)=> Values.Where(x => x.Id == id).FirstOrDefault();
        

        public void Save(StockDTO entity)
        {
            Stock stock = new Stock
            {
                Date = entity.Date,
                Entrance = entity.Entrance,
                Amount = entity.Amount,
                ProductId = entity.ProductId,
                WarehouseId = entity.WarehouseId,
            };
            Db.Stocks .Add(stock);
            Db.SaveChanges();
        }

        public void Update(StockDTO entity, int id)
        {
            Stock stock=Db.Stocks .FirstOrDefault(x => x.Id == id);
            stock .ProductId = entity.ProductId;
            stock .WarehouseId = entity.WarehouseId;
            stock .Date = entity.Date;
            stock.Entrance = entity.Entrance;
            stock .Amount = entity.Amount;
            Db.Stocks.Update(stock);
            Db.SaveChanges ();  
        }
    }
}
