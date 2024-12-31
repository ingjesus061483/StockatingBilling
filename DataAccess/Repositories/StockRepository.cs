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
    public class StockRepository : IRepository<StockDTO>, IOperation<StockDTO>
    {
        public StockatingDbContext Db { get; set; }

        public IQueryable<StockDTO> Values => Db.Stocks.Include(s => s.Product).Include(s => s.Warehouse).Select(x => new StockDTO
        {
            Date = x.Date,
            Entrance = x.Entrance,
            Amount = x.Amount,
            Id = x.Id,
            Product = x.Product,
            ProductId = x.ProductId,
            WarehouseId = x.WarehouseId,
            Warehouse = x.Warehouse,
        });
        ExcelRepository ExcelRepository { get; set; }
        public StockRepository(StockatingDbContext db,ExcelRepository _excelRepository )
        {
            Db = db;
            ExcelRepository = _excelRepository;
        }

        public void DeleteById(int id)
        {
            Stock stock = Db.Stocks.FirstOrDefault(x => x.Id == id);
            Db.Stocks.Remove(stock);
            Db.SaveChanges();
        }

        public StockDTO GetById(int id) => Values.Where(x => x.Id == id).FirstOrDefault();

        public IQueryable<StockDTO >GetStockDTOs(int productId, int WarehouseId,bool entrance = true)
        {
            return Values.Where(x => x.Entrance==entrance  && x.ProductId == productId && x.WarehouseId == WarehouseId);
        }

        public decimal  GetTotalStock(int productId  ,int WarehouseId )
        {
            decimal totalEntrance = Values.Where(x => x.Entrance && x.ProductId == productId && x.WarehouseId == WarehouseId).Sum(x => x.Amount);
            decimal totalExit = Values.Where(x => !x.Entrance && x.ProductId == productId && x.WarehouseId == WarehouseId).Sum(x => x.Amount);
            return totalEntrance - totalExit;
        }
        public void Save(List<Stock> stocks)
        {
            Db.Stocks .AddRange(stocks);
            Db.SaveChanges();
        }
        public void Save(StockDTO entity)
        {
            Stock stock = new Stock
            {
                Date = entity.Date,
                Entrance = true,
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

        public void Print(StockDTO entity)
        {
            throw new NotImplementedException();
        }

        public void Export(Dictionary<string, Array> entities)
        {
            ExcelRepository.Export(entities);
        }
    }
}
